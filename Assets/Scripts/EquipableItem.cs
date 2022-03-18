using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EquipableItem : Item
{
    public int vitality;
    public int warmth;
    [Space]
    public EquipmentType EquipmentType;
}

public enum EquipmentType
{
    Edible,
    Hat,
    Shirt,
    Sock,
    Trousers,
    Tool
}



