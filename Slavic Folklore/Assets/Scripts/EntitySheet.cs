using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UI;
public class EntitySheet : MonoBehaviour
{
    //plug in the relevant SO here 
    public EntitiesSO relevantSO;
    
    //list the UI elements that we're gonna want to alter via SO
    public TMP_Text basicInfo;
    public TMP_Text entityName;

    public Image entityImage;
    
    void Start()
    {
        entityName.text = relevantSO.name;
        basicInfo.text = relevantSO.partialInfo;
        entityImage.sprite = relevantSO.artShadow;

    }
    
}
