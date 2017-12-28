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
		if (!PlayerManagement.Instance.isPlaying)
			return;
		speed += Time.deltaTime * 10;
		float h = speed * Time.deltaTime;
		rb.velocity = new Vector2(h, rb.velocity.y);

		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			rb.AddForce(new Vector2(0, jumbSpeed), ForceMode2D.Impulse);
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

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.transform.tag.Equals("Ground"))
		{
			isGrounded = true;
		}
	}
	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.transform.tag.Equals("Ground"))
		{
			isGrounded = false;
		}
	}
	#endregion
}
