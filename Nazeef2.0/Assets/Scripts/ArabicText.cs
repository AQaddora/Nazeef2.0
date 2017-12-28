using UnityEngine;
using System.Collections;
using ArabicSupport;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ArabicText : MonoBehaviour {
	
	[HideInInspector]
	public Text TextComponent;

	public bool haveAStartText = true;
    [TextArea]
    public string startText;
	public bool tashkeel = true;
	public bool hinduNumbers = false;

    void Start ()
    {
		TextComponent = gameObject.GetComponent<Text>();
		if (haveAStartText)
			SetText(startText);
	}

    public void SetText(string s)
    {
        TextComponent.text = ArabicFixer.Fix(s, tashkeel, hinduNumbers);
    }
    public string GetText()
    {
        return ArabicFixer.Fix(TextComponent.text, tashkeel, hinduNumbers);
    }
}
