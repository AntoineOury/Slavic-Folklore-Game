using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "InspectItem", menuName = "Scriptable Object/Inspect Details")]
public class InspectSO : ScriptableObject
{
    public TMP_Text itemName;
    public TMP_Text itemDesc;
}
