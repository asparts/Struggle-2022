using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EquipmentPanel : MonoBehaviour
{
    [SerializeField] Transform equipmentSlotsParent;
    [SerializeField] EquipmentSlot[] equipmentSlots;

    public event Action<Item> OnItemRightClickedEvent;

    private void Awake()
    {
        for (int i = 0; i < equipmentSlots.Length; i++)
        {
            equipmentSlots[i].OnRightClickEvent += OnItemRightClickedEvent;
        }
    }


    private void OnValidate()
    {
        equipmentSlots = equipmentSlotsParent.GetComponentsInChildren<EquipmentSlot>();
    }


    public bool AddItem(EquipableItem item, out EquipableItem previousItem)
    {
        for(int i = 0; i < equipmentSlots.Length; i++) {
           if( equipmentSlots[i].EquipmentType == item.EquipmentType)
            {
                previousItem = (EquipableItem)equipmentSlots[i].item;
                equipmentSlots[i].item = item;
                return true;
            }
            
        }
        previousItem = null;
        return false;
    }
    public bool RemoveItem(EquipableItem item)
    {
        for (int i = 0; i < equipmentSlots.Length; i++)
        {
            if (equipmentSlots[i].item == item)
            {
                equipmentSlots[i].item = null;
                return true;
            }

        }
        return false;
    }
}
