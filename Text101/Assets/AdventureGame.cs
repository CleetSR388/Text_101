using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;

    // Use this for initialization
	void Start ()
    {
        textComponent.text = ("Your a space marine and" +
"you've lost all contact with your team and need to find them!" +
"You are alone. After beaming in, to arrive at your current location."
+ "Your inside a structure doors all around you." + 
"Clearly you can see out the window it appears you are possibly on Mars" + 
"Your options are");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
