using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DiaryOpenCloseButton", menuName = "Scriptable Objects/DiaryButton")]
public class DiaryButtonSO : ScriptableObject
{
    public Sprite openDiary;
    public Sprite closedDiary;
    
    public GameObject diaryUI;
}
