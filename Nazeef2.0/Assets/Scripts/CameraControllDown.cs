using UnityEngine;

public class CameraControllDown : MonoBehaviour 
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
		float yPos = Mathf.Clamp(transform.position.y, -2000f, 2.74f);
        float xPos = Mathf.Clamp(transform.position.x, 0, 0);
        transform.position = new Vector3(xPos, yPos, transform.position.z);
	}
	#endregion
}
