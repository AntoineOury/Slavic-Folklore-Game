using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InspectDetails : MonoBehaviour
{
    public InspectSO relevantItemSO;

    public TMP_Text itemName;
    public TMP_Text itemDetails;

    // public InspectTrigger inspectTriggerScript;
        
    // Start is called before the first frame update
    void Start()
    {
        // relevantItemSO = inspectTriggerScript.itemDetailsSO;
        // itemName.text = relevantItemSO.itemName;
        // itemDetails.text = relevantItemSO.itemDesc;
        
        if (relevantItemSO != null)
        {
            Debug.Log("itemName: " + relevantItemSO.itemName);
            Debug.Log("itemDetails: " + relevantItemSO.itemDesc);

            itemName.text = relevantItemSO.itemName;
            itemDetails.text = relevantItemSO.itemDesc;
        }
        else
        {
            Debug.LogError("relevantItemSO is not assigned!");
        }
    }

}
