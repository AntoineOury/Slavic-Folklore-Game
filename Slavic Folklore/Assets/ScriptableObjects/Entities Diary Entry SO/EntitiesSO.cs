using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EntitiesSheet", menuName = "Scriptable Objects/Entities Page")]
public class EntitiesSO : ScriptableObject
{
   public new string name;
   public string partialInfo;
   public string fullInfo;

   //artwork of the entity before the quest for it has been completed and after
   public Sprite artShadow;
   public Sprite entityArt;
   
   //check if quest for that entity has been completed so that it can replace the partialInfo with the fullInfo
   
}
