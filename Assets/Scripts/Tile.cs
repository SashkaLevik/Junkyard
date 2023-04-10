using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private bool _isWalkable;
    public BaseUnit _ocupiedUnit;

    public bool IsWalkable => _isWalkable && _ocupiedUnit == null;
}
