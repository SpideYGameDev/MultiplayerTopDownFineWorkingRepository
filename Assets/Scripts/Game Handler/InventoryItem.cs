using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    
    [Header("UI")]
    public Image _image;
    public Text countText;
    private Transform itemdragParent;
    [HideInInspector]public Item item;
    [HideInInspector]public int count=1;
    [HideInInspector] public Transform parentAfterDrag;
    public void InitialiseItem(Item newItem, Transform newdragParent)
    {
        item = newItem;
        _image.sprite = newItem.image;
        itemdragParent = newdragParent;
        RefreshCount();
    }

    public void RefreshCount()
    {
        countText.text = count.ToString();
        bool textActive = count > 1;
        countText.gameObject.SetActive(textActive);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        _image.raycastTarget = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(itemdragParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        _image.raycastTarget = true;
        transform.SetParent(parentAfterDrag);
    }
}
