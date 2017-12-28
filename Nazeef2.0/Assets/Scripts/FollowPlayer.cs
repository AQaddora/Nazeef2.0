/*
* @GamerBox 2018
*/
using UnityEngine;

public class FollowPlayer : MonoBehaviour 
{
	#region Variables
	private Transform target;
	#endregion
	
	#region Unity Methods
	private void Awake()
	{
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}

	private void Update()
	{
		transform.position = target.position;
	}
	#endregion
}
