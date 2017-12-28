/*
* @GamerBox 2018
*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour 
{
	#region Variables
	#endregion
	
	#region Unity Methods
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.transform.tag.Equals("Player"))
		{
			Debug.Log("You Won!!");
			SceneManager.LoadScene(0);
		}
	}
	#endregion
}
