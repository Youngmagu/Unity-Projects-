﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;

public class ToggleTest : MonoBehaviour {

    ToggleGroup toggleGroupInstance;

    public Toggle currentSelection
    {
        get { return toggleGroupInstance.ActiveToggles().FirstOrDefault(); }
    }

	// Use this for initialization
	void Start () {
        toggleGroupInstance = GetComponent<ToggleGroup>();
        Debug.Log("First Selected " + currentSelection.name);

        SelectToggle(2);
        
	}
    public void SelectToggle(int id)
    {
        var toggles = toggleGroupInstance.GetComponentsInChildren<Toggle> ();
        toggles [id].isOn = true;
    }
}