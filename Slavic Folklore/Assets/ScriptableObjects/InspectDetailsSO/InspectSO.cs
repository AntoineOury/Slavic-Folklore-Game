using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InspectItem", menuName = "Scriptable Objects/Inspect Details")]
public class InspectSO : ScriptableObject
{
    public string itemName;
    
    [TextArea(2, 5)]
    public string itemDesc;
}