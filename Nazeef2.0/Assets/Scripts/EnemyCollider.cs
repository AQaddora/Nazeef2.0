/*
* @GamerBox 2018
*/
using UnityEngine;

public class EnemyCollider : MonoBehaviour 
{
	#region Variables
	#endregion
	
	#region Unity Methods
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			PlayerManagement.Instance.UpdateHealth();
		}
		else if (collision.tag == "bullet")
		{
			Destroy(collision.gameObject);
			Destroy(gameObject);
		}
	}
	#endregion
}
