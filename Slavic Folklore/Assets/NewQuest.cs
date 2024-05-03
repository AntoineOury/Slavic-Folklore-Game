using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class NewQuest : MonoBehaviour
{
    public QuestSO relevantSO;
    
    public GameObject newQuest;
    public TMP_Text questTitle;

    public Animator questText;

    public Button acceptQuest;

    public PostProcessVolume ppVol;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(QuestAnim());
            
        }
    }

   IEnumerator QuestAnim()
   {
       newQuest.gameObject.SetActive(true);
       questTitle.text = relevantSO.questName;
       ppVol.enabled = true;
       
       yield return new WaitForSeconds(3);

       questText.enabled = true;

       yield return new WaitForSeconds(1);
       
       acceptQuest.gameObject.SetActive(true);
   }
}
