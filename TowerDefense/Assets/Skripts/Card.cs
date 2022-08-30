using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Card/new Card", fileName = "New card", order = 51)]
public class Card : ScriptableObject
{
    public Sprite icon;
    public GameObject prefab;
    public int cost;
}
