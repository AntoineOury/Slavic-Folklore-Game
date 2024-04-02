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

    //UI text prompts:
    public TMP_Text pressSpace;
    
    
    private int activeLineIndex = 0;

    //link to DialogueTrigger.cs
    public DialogueTrigger dia;
    
    public void Start()
    {
        characterName.text = relevantSO.characterName;
        DisplayLine();
        dia = transform.parent.GetComponentInChildren<DialogueTrigger>();
        
        if (dia != null)
        {
            // Proceed with other operations
        }
        else
        {
            Debug.LogError("DialogueTrigger reference is not assigned.");
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
            activeLineIndex++;
            DisplayLine();
            
            Debug.Log("line nr: " + activeLineIndex);
            
            //display 'space to continue' prompt
            pressSpace.gameObject.SetActive(false);
            
        }
        else
        {
            EndDialogue();
         
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
            
            //display 'space to continue' prompt
            pressSpace.gameObject.SetActive(true);
            
        }
        else
        {
            characterLines.text = "";
        }
    }

    // method for ending dialogue aka closing the dialogue bubble
    void EndDialogue()
    {
        Debug.Log("dialogue ended");
        dia.dialogueBubble.gameObject.SetActive(false);

        //resets the dialogue lines to the beginning
        activeLineIndex = 0;

    }
  
}
