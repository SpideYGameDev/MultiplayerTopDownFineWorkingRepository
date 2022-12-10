using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
[CreateAssetMenu(menuName = "Scriptable Object/Item")]
public class Item : ScriptableObject
{
    

    [Header("Only GamePlay")]
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range =   new Vector2Int(5,4);
    [Header("Only UI")]
    public bool Stackable = true;
    [Header("Both")]
    public Sprite image;
}
    public enum ItemType
    {
        Tool,
        Collectable
    }

    public enum ActionType
    {
        Dig,
        Mine
    }

