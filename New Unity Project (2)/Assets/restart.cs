using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour {
  void OnGUI () {
    if (GUILayout.Button ("R = Restart")) {
      Application.LoadLevel(Application.loadedLevel);
    }
    if (GUI.Button (new Rect (10,30,75,20), "Restart")) {
      Application.LoadLevel(Application.loadedLevel);
    }
  }

  void Update () {
    if (Input.GetKey ("r")) {
    Application.LoadLevel(Application.loadedLevel);
    }
    //Requires this button to be set in the Input Manager
    if (Input.GetButtonDown ("Restart")) {
      Application.LoadLevel(Application.loadedLevel);
    }
  }
}
