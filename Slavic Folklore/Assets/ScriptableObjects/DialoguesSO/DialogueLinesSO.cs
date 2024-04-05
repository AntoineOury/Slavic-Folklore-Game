using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Code written based on this tutorial with modifications: https://www.youtube.com/watch?v=YJLcanHcJxo

[System.Serializable]
public struct Line
{
   [TextArea(2, 5)] 
   public string text;
}

[CreateAssetMenu(fileName = "DialogueLines", menuName = "Scriptable Objects/Dialogue Lines")]
public class DialogueLinesSO : ScriptableObject
{
   [Header("NPC Name")]
   public string characterName;
   
   [Header("Dialogue Lines")]
   //array of lines elements that can be written/altered in inspector
   public Line[] lines;
}
