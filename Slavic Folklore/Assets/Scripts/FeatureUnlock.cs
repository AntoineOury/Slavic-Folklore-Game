using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FeatureUnlock : MonoBehaviour
{
    public GameObject motanka;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            motanka.gameObject.SetActive(true);
        }
    }
}
