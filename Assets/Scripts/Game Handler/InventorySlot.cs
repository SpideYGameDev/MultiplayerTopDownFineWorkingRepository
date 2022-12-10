using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour, IDropHandler
{
    public Image invevtorySlotimage;
    public Color SelectedColor,notSelectedColor;
    private void Awake() {
        DeSelect();
    }
    public void Select()
    {
        invevtorySlotimage.color  = SelectedColor;
    }
    public void DeSelect()
    {
        invevtorySlotimage.color = notSelectedColor;
    }
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            InventoryItem inventoryItem = eventData.pointerDrag.GetComponent<InventoryItem>();
            inventoryItem.parentAfterDrag = transform;
        }

    }
}
