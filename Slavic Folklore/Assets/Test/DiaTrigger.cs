using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaTrigger : MonoBehaviour
{
  public GameObject Player;
  public Image dialogueDisplay;
  public void OnTriggerEnter(Collider other)
  {
    dialogueDisplay.gameObject.SetActive(true);
  }

  public void OnTriggerExit(Collider other)
  {
    dialogueDisplay.gameObject.SetActive(false);
  }
}
