/*
* @GamerBox 2018
*/
using UnityEngine;

public class AudioManager : MonoBehaviour 
{
	#region Variables
	public static AudioManager Instance;
	private AudioSource audioSource;
	#endregion
	
	#region Unity Methods
	private void Start()
	{
		DontDestroyOnLoad(this);

		audioSource = GetComponent<AudioSource>();

		if (Instance != null)
			Destroy(this.gameObject);
		else
			Instance = this;
	}

	public void PlayEffect(AudioClip clip)
	{
		Debug.Log(clip.name);
		audioSource.PlayOneShot(clip, 1);
	}
	#endregion
}
