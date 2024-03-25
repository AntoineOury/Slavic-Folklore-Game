using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryButtons : MonoBehaviour
{

// code from forum discussion: https://forum.unity.com/threads/active-deactivate-gameobjects-in-a-list.545565/

    public List<GameObject> entitiesPages;

    private int currentActiveIndex = 0;

   public void Start()
    {
       PagesFlipForward();
       PageFlipBack();
    }

   public void PagesFlipForward()
    {
        entitiesPages[currentActiveIndex].SetActive(false);
        currentActiveIndex++;

        if (currentActiveIndex >= entitiesPages.Count)
        {
            currentActiveIndex = 0;
        }
        
        entitiesPages[currentActiveIndex].SetActive(true);
    }

   public void PageFlipBack()
   {
       entitiesPages[currentActiveIndex].SetActive(false);
       currentActiveIndex--;

       if (currentActiveIndex < 0)
       {
           currentActiveIndex = entitiesPages.Count - 1;
       }
       
       entitiesPages[currentActiveIndex].SetActive(true);
   }
}
