using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueLine" , menuName = "Scriptable Objects/Dialogue System/RandomNPC")]
public class DialogueSO : ScriptableObject
{
   //name of the speaker NPC
   [SerializeField] private string npcSpeaker;
   [SerializeField] private string npcText;

   
}
