/*
* @GamerBox 2018
*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogBox : MonoBehaviour 
{
	#region Variables
	public static DialogBox Instance;
	public string[] sentances;
	public ArabicText text;
	private AlphaUI dialogAlpha;
	private AlphaUI textAlpha;
	private int current = 0;

	#endregion

	#region Unity Methods
	private void Awake()
	{
		Invoke("ShowDialogBox", 0.3f);
		dialogAlpha = GetComponent<AlphaUI>();
		textAlpha = text.GetComponent<AlphaUI>();
	}
	public void OnClick_DialogBox()
	{
		current++;
		if(current >= sentances.Length)
		{
			dialogAlpha.Hide();
			if(SceneManager.GetActiveScene().buildIndex != 0)
				PlayerManagement.Instance.isPlaying = true;
			current = 0;
		}
		textAlpha.Hide();
		Invoke("ChangeTextAndShow", textAlpha.duration);
	}

	void ChangeTextAndShow()
	{
		text.SetText(sentances[current]);
		textAlpha.Show();
	}
	void ShowDialogBox()
	{
		dialogAlpha.Show();
		text.SetText(sentances[current]);
	}

	public void ShowDialogBoxWithThisString(string[] input)
	{
		sentances = input;
		text.SetText(sentances[0]);
		ShowDialogBox();
	}
	#endregion
}
