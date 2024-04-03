using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectTrigger : MonoBehaviour
{
    public GameObject Player;
    public Image inspectIcon;
    public void OnTriggerEnter(Collider other)
    {
        inspectIcon.gameObject.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        inspectIcon.gameObject.SetActive(false);
    }
}
