using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(CrossPlatformInputManager.GetButton("Submit"))
    {
        Application.LoadLevel(1);
    }else if (CrossPlatformInputManager.GetButton("Cancel"))
    {

    }
	}


   
}
