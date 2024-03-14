using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Line
{
   [TextArea(2, 5)] 
   public string text;
}

[CreateAssetMenu(fileName = "DialogueLines", menuName = "Scriptable Objects/Dialogue Lines")]
public class DialogueLinesSO : ScriptableObject
{
   public string characterName;
   
   //array of line elements that can be written/altered in inspector
   public Line[] lines;
}
