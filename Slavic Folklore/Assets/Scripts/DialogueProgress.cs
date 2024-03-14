using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueProgress : MonoBehaviour
{
    //Code written based on this tutorial with modifications: https://www.youtube.com/watch?v=YJLcanHcJxo
    //and debugged with ChatGPT
    
    //link to DialogueLinesSO so that its content can be displayed
    public DialogueLinesSO relevantSO;
    
    //list of UI elements we want to alter with DialogueLinesSO
    public TMP_Text characterName;
    public TMP_Text characterLines;
    
    private int activeLineIndex = 0;
    
    
    public void Start()
    {
        characterName.text = relevantSO.characterName;
        DisplayLine();
    }


    public void Update()
    {
   //by pressing space we are moving to the next line of the dialogue
        if (Input.GetKeyDown("space"))
        {
            AdvanceDialogue();
        }
    }

    void AdvanceDialogue()
    {
        //we move forward in the dialogue lines
        if (activeLineIndex < relevantSO.lines.Length)
        {
            activeLineIndex += 1;
            DisplayLine();
        }
        else
        {
            activeLineIndex = 0;
            DisplayLine();
        }
    }

    void DisplayLine()
    {
        //we display lines one by one from the lines array in the SO
        if (relevantSO.lines.Length > 0)
        {
            activeLineIndex = Mathf.Clamp(activeLineIndex, 0, relevantSO.lines.Length - 1);
            Line line = relevantSO.lines[activeLineIndex];

            characterLines.text = line.text;
        }
        else
        {
            characterLines.text = "";
        }
    }
}
