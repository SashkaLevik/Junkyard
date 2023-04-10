using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUnit", menuName = "ScriptableUnit")]
public class ScriptableUnits : ScriptableObject
{    
    public Faction _faction;
    public BaseUnit _unitPrefab;
    public BaseUnit[] _prefabs;

    public Faction GetRandomFaction(Faction faction)
    {
        faction = (Faction)Random.Range(1, 3);
        return faction;
    }

    public BaseUnit GetRandomUnit()
    {
        int randomPrefab = Random.Range(0, _prefabs.Length);
        _unitPrefab = _prefabs[randomPrefab];
        return _unitPrefab;
    }

}

public enum Faction
{
    Enemy = 1,
    Player = 2
}
