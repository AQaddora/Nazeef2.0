/*
* @GamerBox 2018
*/
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMovement : MonoBehaviour 
{
	#region Variables
	public float speed = -5;

	private Rigidbody2D rb;
	#endregion
	
	#region Unity Methods
	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
	}
	#endregion
}
