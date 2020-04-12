﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class List_Checker : MonoBehaviour
{
    public InputField input;
    public TextAsset textFileWithNames;
    public Text display;

    private List<string> names;

    private void Start()
    {
        names = new List<string>(); // Instantiate the list

        var namesFromFile = textFileWithNames.text.Split('\n'); // The below code reads the text file and splits it into lines.

        for (var i = 0; i < namesFromFile.Length; i++) // This code loops though every single line in the text file
        {
            if (string.IsNullOrWhiteSpace(namesFromFile[i])) continue; // If there's an empty line, continue

            names.Add(namesFromFile[i].ToUpper()); // Add each line to the list of names.
            print("It's working!");
        }
    }

    private void Update()
    {        
        if (input.text == "") // If there's nothing in the text box, show instructions.
        {
            display.text = "Type a name to see if it's a Marvel Character!";
        }
        
        // Otherwise, check to see if the name is in the list.
        else
        {
            display.text = "No, it's not."; // Start by setting the display to say "not in list".
            
            for (var i = 0; i < names.Count; i++) // Loop through the entire list
            {
                
                if (input.text.ToUpper() == names[i]) // If any of the names in the list match what in the input field, say it's in the list.
                {
                    display.text = "Yes, it is!";
                }
            }
        }
    }
}