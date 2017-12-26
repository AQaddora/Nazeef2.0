/*
* @GamerBox 2018
*/
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour 
{
	#region Variables

	public static PlayerMovement Instance;
	public float speed = 10;
	public float jumbSpeed = 10;
	public Image healthBar;
	public float health = 100;
	public GameObject bulletPrefab;
	private Rigidbody2D rb;
	private bool isGrounded = false;
	private float scaleX;
	#endregion
	
	#region Unity Methods
	private void Awake()
	{
		Instance = this;
		scaleX = transform.localScale.x;
		rb = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{

		if (Input.GetKeyDown(KeyCode.X) || Input.GetMouseButtonDown(0))
		{
			GameObject obj = Instantiate(bulletPrefab);
			obj.transform.SetParent(transform);
		}
		isGrounded = transform.position.y <= -4.5f;
		float h = speed * Time.deltaTime;
		rb.velocity = new Vector2(h, rb.velocity.y);

		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			rb.AddForce(new Vector2(0, jumbSpeed * Time.deltaTime));
		}

		if(rb.velocity.x < 0)
		{
			transform.localScale = new Vector2(-scaleX, transform.localScale.y);
		}
		else
		{
			transform.localScale = new Vector2(scaleX, transform.localScale.y);
		}
	}

	public void UpdateHealth()
	{
		health -= 25;
		if (health <= 0)
			SceneManager.LoadScene(0);

		healthBar.fillAmount -= 0.25f;
	}
	#endregion
}
