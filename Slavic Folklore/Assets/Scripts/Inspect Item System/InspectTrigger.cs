using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    }

    public void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.X))
        {
            motankaGuide.gameObject.SetActive(true);
        }
    }
}
