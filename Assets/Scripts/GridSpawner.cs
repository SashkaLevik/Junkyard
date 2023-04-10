using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    [SerializeField] private float _xStartPos, _yStartPos;
    [SerializeField] private int _wedth, _height;
    [SerializeField] private float _xSpace, _ySpace;
    [SerializeField] private GameObject _battleField;
    [SerializeField] private Tile[] _tilePrefabs;

    
    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        for (int x = 0; x < _wedth; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                int randomTile = Random.Range(0, _tilePrefabs.Length); 
                var spawnedTile = Instantiate(_tilePrefabs[randomTile], new Vector3(_xStartPos + (_xSpace * (x)), _yStartPos + (-_ySpace * (y)), 20f), Quaternion.identity, _battleField.transform.parent);
            }
        }
    }    
}
