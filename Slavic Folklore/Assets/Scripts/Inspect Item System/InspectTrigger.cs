using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.PostProcessing;

public class InspectTrigger : MonoBehaviour
{
    // [Tooltip("Drag and drop the Scriptable Object that contains the details about the item associated to this trigger")]
    // public ScriptableObject itemDetailsSO;
    
    public InspectSO relevantItemSO;

    public TMP_Text itemName;
    public TMP_Text itemDetails;
    
    public GameObject player;
    public Image inspectIcon;
    public GameObject motankaGuide;
    
    //UI that disappears when MotankaGuide opens
    public Button diaryButton;
    public Button motankaButton;

    //mainCam post processing volume (for background blur)
    public PostProcessVolume ppVol;
    
    //checks if player is in the trigger area
    private bool inRange = false;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inspectIcon.gameObject.SetActive(true);
            inRange = true;
            Debug.Log("Press X to inspect");
            
            
            itemName.text = relevantItemSO.itemName;
            itemDetails.text = relevantItemSO.itemDesc;
            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        inspectIcon.gameObject.SetActive(false);
        motankaGuide.gameObject.SetActive(false);
        inRange = false;
        
        //disable background blur
        ppVol.enabled = false;
    }

    public void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.X))
        {
            //display Guide
            motankaGuide.gameObject.SetActive(true);
            
            //blur background when Guide is opened
            ppVol.enabled = true;
            
            //hide other menu buttons
            diaryButton.gameObject.SetActive(false);
            motankaButton.gameObject.SetActive(false);
            
            
            //inspect prompt disappears after Guide displayed
            inspectIcon.gameObject.SetActive(false);
            
        }
    }
}
