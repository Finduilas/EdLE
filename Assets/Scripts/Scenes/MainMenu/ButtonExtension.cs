using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonExtension : MonoBehaviour {

	public Text label;
	public Image logo;
	public Button btnScript;
	private Color localcolor;
	private bool localInteractable;

	// Use this for initialization
	void Start () {
		localInteractable = btnScript.interactable;
		MouseExit (); //call for init color
	}
	
	// Update is called once per frame
	void Update () {
		if (localInteractable != btnScript.interactable) {
			localInteractable = btnScript.interactable;
			MouseExit ();
			//on passe ici si le bouton devient interactable ou non. On peut donc en changer l'etat ca repercute la couleur sur le reste.
		}
		logo.color = localcolor;
		label.color = localcolor;
	}

	//TODO : Gerer la couleur au click.

	public void MouseEnter() {
		Debug.Log ("on mouse enter");
		if (localInteractable) {
			localcolor = btnScript.colors.highlightedColor;
		} else {
			localcolor = btnScript.colors.disabledColor;
		}
	}
	public void MouseExit() {
		Debug.Log ("on mouse exit");
		if (localInteractable) {
			localcolor = btnScript.colors.normalColor;
		} else {
			localcolor = btnScript.colors.disabledColor;
		}
	}
}
