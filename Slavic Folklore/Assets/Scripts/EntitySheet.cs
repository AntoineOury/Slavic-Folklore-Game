using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EntitySheet : MonoBehaviour
{
    //plug in the relevant SO here 
    public EntitiesSO relevantSO;
    
    //list the UI elements that we're gonna want to alter via SO
    public TMP_Text basicInfo;
    
    void Start()
    {
        basicInfo.text = relevantSO.partialInfo;
    }
    
}
