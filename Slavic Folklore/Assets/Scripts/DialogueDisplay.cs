using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
public class DialogueDisplay : MonoBehaviour
{
    public GameObject dialogueTrigger;

    public TMP_Text pressE;

    public Image dialogueBubble;
    
    //checking if dialogue bubble is already there 
    private bool isDialogueBubbleActive = false;
    
    // Start is called before the first frame update
    void Update()
    {
        //if E is pressed AND the dialogueBubble is not already active
        if (Input.GetKeyDown(KeyCode.E) && !isDialogueBubbleActive)
        {
            
            //when E is pressed "Press E" instruction disappears 
            pressE.gameObject.SetActive(false);
            
            //when E is pressed the Dialogue bubble appears and dialogue 
            // is initiated
            dialogueBubble.gameObject.SetActive(true);
            
            //flagging that the dialogueBubble is ACTIVE (not to spawn it multiple time if
            //player spams E
            isDialogueBubbleActive = true;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        pressE.gameObject.SetActive(true);
        Debug.Log("Press E to talk");
        
    }
    
}
