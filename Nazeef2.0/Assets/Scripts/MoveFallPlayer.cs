using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.SceneManagement;

public class MoveFallPlayer : MonoBehaviour {

    #region Variables
    public static MoveFallPlayer Instance;
	public bool playerDamaged = false;
    public float speed;
	public bool right;
	public bool left;

	private Rigidbody2D rb;
	#endregion

	void Awake () {
        Instance = this;
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
	{
		rb.gravityScale = PlayerManagement.Instance.isPlaying ? 1 : 0;
		if (!PlayerManagement.Instance.isPlaying)
			return;
		Camera.main.GetComponent<PostProcessingBehaviour>().profile.vignette.enabled = playerDamaged;
        float xPos = Mathf.Clamp(transform.position.x, -6.97f, 7.23f);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

        if (right) {
            transform.Translate(Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector3(1,1,1);
        }
            

        else if (left) {
            transform.Translate(Time.deltaTime * -speed, 0, 0);
            transform.localScale = new Vector3(-1, 1, 1);
        }    
    }

    public void RightTrue()
    {
        right = true;
    }
    public void RightFalse()
    {
        right = false;
    }

    public void LeftTrue()
    {
        left = true;
    }

    public void LeftFalse()
    {
        left = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "End")
        {
			SceneManager.LoadScene(0);   
        }
    }
}
