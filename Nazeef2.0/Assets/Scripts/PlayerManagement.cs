/*
* @GamerBox 2018
*/
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManagement : MonoBehaviour 
{
	#region Variables
	public static PlayerManagement Instance;
	public Image healthBar;
	public float health = 100;
	public AudioClip damageEffect;
	public bool isPlaying = false;
	#endregion

	#region Unity Methods
	private void Awake()
	{
		Instance = this;
	}

	public void UpdateHealth()
	{
		AudioManager.Instance.PlayEffect(damageEffect);
		health -= 25;
		if (health <= 0)
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

		healthBar.fillAmount -= 0.25f;
	}
	#endregion
}
