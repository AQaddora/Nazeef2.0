/*
* @GamerBox 2018
*/
using UnityEngine;

public class bulletScript : MonoBehaviour 
{
	#region Variables
	#endregion

	#region Unity Methods
	private void Awake()
	{
		transform.tag = "bullet";
		Invoke("DestroyThis", 3);
	}

	void DestroyThis()
	{
		Destroy(gameObject);
	}
	#endregion
}
