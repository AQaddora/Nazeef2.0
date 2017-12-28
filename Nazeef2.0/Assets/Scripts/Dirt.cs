/*
* @GamerBox 2018
*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dirt : MonoBehaviour 
{
	#region Variables
	private Transform spot;
	public GameObject bulletPrefab;

	private GameObject obj;
	private bool missed = false;
	#endregion
	
	#region Unity Methods
	private void Awake()
	{
		spot = GameObject.Find("Spot").transform;
	}

	private void Update()
	{
		if(obj != null)
		{
			Vector3 pos = Vector3.Lerp(obj.transform.position, transform.position, Time.deltaTime * 10);
			obj.transform.position = pos;
		}
		if ((spot.position.x - 9f > transform.position.x && !missed && SceneManager.GetActiveScene().buildIndex == 1) ||
			(spot.position.y + 7f < transform.position.y && !missed && SceneManager.GetActiveScene().buildIndex == 2))
		{
			PlayerManagement.Instance.UpdateHealth();
			missed = true;
			Destroy(transform.gameObject);
		}
	}
	private void OnMouseDown()
	{
		obj = Instantiate(bulletPrefab, spot.transform.position, Quaternion.identity);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "bullet")
		{
			Destroy(collision.gameObject);
			Destroy(this.gameObject);
		}
		else if(collision.tag == "Player")
		{
			collision.GetComponent<PlayerManagement>().UpdateHealth();
			Destroy(gameObject);
		}
	}
	#endregion
}
