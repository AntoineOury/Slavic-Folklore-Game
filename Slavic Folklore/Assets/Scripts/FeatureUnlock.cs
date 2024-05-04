using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class FeatureUnlock : MonoBehaviour
{
  [Tooltip("drag in MainCamera to blur background")]
  public PostProcessVolume ppVol;

  [Tooltip("drag in Unlocked Feature element")]
  public Animator uFeatureAnim;

  public GameObject uFObject;

  [Tooltip("write duration of the animation")]
  public float animDuration;
  
  //freeze player for the message pop-up duration
  [Tooltip("drag Player in")]
  public PlayerMovement playermovement;

  public GameObject newFeatureUnlocked;

  //check if Coroutine already ran
   private bool featureUnlockFlag = false;
   
  
  private void OnTriggerExit(Collider other)
  {
    if (other.CompareTag("Player") && featureUnlockFlag == false)
    {
      StartCoroutine(UnlockFeature());
      featureUnlockFlag = true;
      Debug.Log(featureUnlockFlag);
    }
  }

  IEnumerator UnlockFeature()
  {
    //freeze player movement
    playermovement.speed = 0f;
    
    ppVol.enabled = true;
    newFeatureUnlocked.gameObject.SetActive(true);
    uFObject.gameObject.SetActive(true);
    uFeatureAnim.enabled = true;
    
    yield return new WaitForSeconds(animDuration);
    
    ppVol.enabled = false;
    newFeatureUnlocked.gameObject.SetActive(false);
    
    //back to original speed
    playermovement.speed = 3f;
    
  }
}
