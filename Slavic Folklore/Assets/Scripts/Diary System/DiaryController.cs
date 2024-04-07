using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class DiaryController : MonoBehaviour
{
    //link the concerned SO here: 
    public GameObject diaryGO;
    
    //ppVolume mainCamera for background blur
    public PostProcessVolume ppVol;

    //change the button image sprite for open/closed
    [SerializeField] private Button diaryButton;
    [SerializeField] private Sprite closedDiary;
    [SerializeField] private Sprite openDiary;
    public void Start()
    {
        //make sure the Diary state is closed
       diaryGO.SetActive(false);
       diaryButton.gameObject.GetComponent<Image>().sprite = closedDiary;

    }

    public void DiaryToggle()
    {
        //if it is closed and the button is pressed make it open 
        if (diaryGO.activeSelf == false)
        {
            diaryGO.SetActive(true);
            diaryButton.gameObject.GetComponent<Image>().sprite = openDiary;
            
            //blur background when Diary is opened
            ppVol.enabled = true;
        }
        else
        {
            diaryGO.SetActive(false);
            diaryButton.gameObject.GetComponent<Image>().sprite = closedDiary;
            
            //DON'T blur background when Diary is closed
            ppVol.enabled = false;
        }
        
    }
    
}
