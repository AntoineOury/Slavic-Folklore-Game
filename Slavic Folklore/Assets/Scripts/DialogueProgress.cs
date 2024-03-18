using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueProgress : MonoBehaviour
{
    //Code written based on this tutorial with modifications: https://www.youtube.com/watch?v=YJLcanHcJxo
    //and debugged with ChatGPT & friends :)
    
    //link to DialogueLinesSO so that its content can be displayed
    public DialogueLinesSO relevantSO;
    
    //list of UI elements we want to alter with DialogueLinesSO
    public TMP_Text characterName;
    public TMP_Text characterLines;
    
    private int activeLineIndex = 0;

    //link to DialogueDisplay.cs
    public DialogueDisplay dia;
    
    public void Start()
    {
        characterName.text = relevantSO.characterName;
        DisplayLine();
        dia = transform.parent.GetComponentInChildren<DialogueDisplay>();
        
        if (dia != null)
        {
            // Proceed with other operations
        }
        else
        {
            Debug.LogError("DialogueDisplay reference is not assigned.");
        }
        
    }

    public void Update()
    {
   //by pressing space we are moving to the next line of the dialogue
        if (Input.GetKeyDown("space"))
        {
            AdvanceDialogue();
        } 
    }

    // ReSharper disable Unity.PerformanceAnalysis
    void AdvanceDialogue()
    {
        //we move forward in the dialogue lines
        if (activeLineIndex < relevantSO.lines.Length -1)
        {
            // activeLineIndex += 1;
            activeLineIndex++;
            DisplayLine();
        }
        else
        {
            // activeLineIndex = 0;
            // DisplayLine();
            // dia.dialogueBubble.gameObject.SetActive(false);
            EndDialogue();
            Debug.Log("Dialog Ended");
         
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

    void EndDialogue()
    {
        Debug.Log("dialogue ended");
        dia.dialogueBubble.gameObject.SetActive(false);
    }
  
}
