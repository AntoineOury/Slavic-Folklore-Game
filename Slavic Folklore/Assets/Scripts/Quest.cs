using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quest : MonoBehaviour
{
    //plug in the relevant SO here
    public QuestSO relevantSO;

    public TMP_Text questName;

    void Start()
    {
        questName.text = relevantSO.questName;
    }
}
