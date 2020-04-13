﻿using System.Collections;
using System.Collections.Generic;
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
        names = new List<string>(); //Create a new list

        var namesFromFile = textFileWithNames.text.Split('\n'); //Split the text into lines

        for (var i = 0; i < namesFromFile.Length; i++) //Go though every line in the text file
        {
            if (string.IsNullOrWhiteSpace(namesFromFile[i])) continue; //Go ahead if there's an empty line

            names.Add(namesFromFile[i].ToUpper().Trim()); //Add each line to the name list
            print("It's working!");
        }
    }

    private void Update()
    {        
        if (input.text == "") 
        {
            display.text = "Type a name to see if it's a Marvel Character!"; //If there's nothing in the text box, show this
        }
        
        else
        {
            display.text = "No, it's not."; //else, check if it's a name from the list and say "not in list"

            for (var i = 0; i < names.Count; i++) //Go through the entire list
            {
                
                if (input.text.ToUpper() == names[i])
                {
                    display.text = "Yes, it is!"; //If the names match the input field, say it's in the list
                }
            }
        }
    }
}