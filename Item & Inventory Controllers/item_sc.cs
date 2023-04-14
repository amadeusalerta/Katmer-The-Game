using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Item",menuName ="Item/Create New Item")]

public class item_sc : ScriptableObject 
{

    public int id;
    public string itemName;
    public int value;
    public Sprite icon_image;


}
