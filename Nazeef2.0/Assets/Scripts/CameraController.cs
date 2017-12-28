using UnityEngine;

public class CameraController : MonoBehaviour 
{
	#region Variables
	private Transform target;
	public float smoothSpeed = 0.2f;
	public Vector3 offset;
	public Vector2 yLimits, xLimits;
	#endregion

	#region Unity Methods
	private void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	private void FixedUpdate()
	{
		if (!PlayerManagement.Instance.isPlaying)
			return;

		Debug.Log(target.name + target.position);
		Vector3 newPos = Vector3.Lerp(transform.position, target.position + offset, smoothSpeed * Time.deltaTime);
		Debug.Log(newPos);
		float xPos = Mathf.Clamp(newPos.x, xLimits.x,xLimits.y);
		float yPos = Mathf.Clamp(newPos.y, yLimits.x,yLimits.y);
		transform.position = new Vector3(xPos, yPos, newPos.z);
	}
	#endregion
}
