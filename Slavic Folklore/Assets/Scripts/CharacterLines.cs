using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CharacterLines : MonoBehaviour
{
    //link to DialogueLinesSO so that its content can be displayed
    public DialogueLinesSO relevantSO;
    
    //list of UI elements we want to alter with DialogueLinesSO
    public TMP_Text characterName;
    public TMP_Text characterLines;


    public void Start()
    {
        characterName.text = relevantSO.characterName;
        // characterLines.text = relevantSO.lines.ToString();
        
        //ChatGPT:
        
        // Concatenate lines into a single string
        string allLines = "";
        foreach (Line line in relevantSO.lines)
        {
            allLines += line.text + "1"; // Add line and a newline character
        }

        // Display concatenated lines
        characterLines.text = allLines;
    }
}
