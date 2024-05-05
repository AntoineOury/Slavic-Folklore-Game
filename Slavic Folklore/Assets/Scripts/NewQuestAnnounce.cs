using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class NewQuestAnnounce : MonoBehaviour
{
    [Tooltip("QuestSO that is relevant to the unlocked quest")]
    public QuestSO relevantSO;
    
    public GameObject newQuest;
    public TMP_Text questTitle;

    [Tooltip("drag in the Quest Title text object")]
    public Animator questTextAnim;

    public Button acceptQuest;

    [Tooltip("drag MainCamera in")]
    public PostProcessVolume ppVol;

    [Tooltip("drag Player in")]
    public PlayerMovement playermovement;
    
    //hide those menu buttons
    public GameObject mainButtons;
    

    private void Start()
    {
        //get the player movement script
        playermovement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //lock player in place
            playermovement.speed = 0f;
            
            StartCoroutine(QuestAnim());
            
        }
    }

   IEnumerator QuestAnim()
   {
       newQuest.gameObject.SetActive(true);
       questTitle.text = relevantSO.questName;
       mainButtons.gameObject.SetActive(false);
       ppVol.enabled = true;
       
       yield return new WaitForSeconds(3);

       //animates quest title text to move up 
       questTextAnim.enabled = true;

       yield return new WaitForSeconds(1);
       
       acceptQuest.gameObject.SetActive(true);
   }
}
