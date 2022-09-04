using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField] private Vector2 _buildingSize;
    [SerializeField] private Renderer _rederer;

    public Vector2 BuildingSize { get => _buildingSize; set {; } }

    public void SetColor(bool isAvailableToBuild)
    {
        if (isAvailableToBuild)
            _rederer.material.color = Color.green;
        else
            _rederer.material.color = Color.red;
    }

    public void ResetColor()
    {
        _rederer.material.color = Color.white;
    }
}
