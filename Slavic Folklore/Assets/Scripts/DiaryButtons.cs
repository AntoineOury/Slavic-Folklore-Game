using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryButtons : MonoBehaviour
{

// code from forum discussion: https://forum.unity.com/threads/active-deactivate-gameobjects-in-a-list.545565/

    public List<GameObject> entitiesPages;

    private int currentActiveIndex = 0;

    private void Update()
    {
        PagesFlip();
    }

    void PagesFlip()
    {
        entitiesPages[currentActiveIndex].SetActive(false);
        currentActiveIndex++;

        if (currentActiveIndex >= entitiesPages.Count)
        {
            currentActiveIndex = 0;
        }
        
        entitiesPages[currentActiveIndex].SetActive(true);
    }
}
