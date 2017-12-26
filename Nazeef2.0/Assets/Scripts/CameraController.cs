using UnityEngine;

public class CameraController : MonoBehaviour 
{
	#region Variables
	private Transform target;
	public float smoothSpeed = 0.2f;
	public Vector3 offset;
	#endregion

	#region Unity Methods
	private void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	private void FixedUpdate()
	{
		Vector3 newPos = Vector3.Lerp(transform.position, target.position + offset, smoothSpeed * Time.deltaTime);
		transform.position = newPos;
		float yPos = Mathf.Clamp(transform.position.y, -0.6f,0.6f);
		transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
	}
	#endregion
}
