using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuUIBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void BtnPNJAmbClicked(){
		SceneManager.LoadScene ("PNJAmbEditor");
	}

	public void BtnPNJAdvClicked(){
		Debug.Log ("btn pnj advanced clicked");
	}

	public void BtnObjClicked(){
		Debug.Log ("btn Obj clicked");
	}

	public void BtnMonstersClicked(){
		Debug.Log ("btn monster clicked ");
	}

	public void BtnMapClicked(){
		Debug.Log ("btn map clicked ");
	}

	public void BtnCraftClicked(){
		Debug.Log ("btn craft clicked");
	}
}
