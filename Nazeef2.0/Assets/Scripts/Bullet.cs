/*
* @GamerBox 2018
*/
using UnityEngine;

public class Bullet : MonoBehaviour 
{
	#region Variables
	private Transform spot;
	#endregion

	#region Unity Methods
	private void Awake()
	{
		spot = GameObject.Find("Spot").transform;
		transform.position = spot.position;
		transform.tag = "bullet";
		Invoke("DestroyThis", 3);
	}
	void DestroyThis()
	{
		Destroy(gameObject);
	}
	#endregion
}
