
using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public string stringToEdit = "What is your answer? ";

    void OnGUI()
    {
        // Make a text field that modifies stringToEdit.
        stringToEdit = GUI.TextField(new Rect(10, 10, 200, 20), stringToEdit, 25);
    }
}