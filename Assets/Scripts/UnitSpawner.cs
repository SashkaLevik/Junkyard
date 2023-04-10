using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;
public class UnitSpawner : MonoBehaviour
{
    [SerializeField] private Transform _heroPos;
    [SerializeField] private Transform _enemyPos;
    [SerializeField] private MoveLogic _moveLogic;

    public List<ScriptableUnits> _units;

    private void Awake()
    {
        _units = Resources.LoadAll<ScriptableUnits>("Enemyes").ToList();
    }

    private void Start()
    {
        SpawnEnemy();
        SpawnHero();
    }

    public void SpawnEnemy()
    {
        for (int i = 0; i < 1; i++)
        {
            var randomEnemy = GetRandomUnit<BaseUnit>(Faction.Enemy);
            var spawnedEnemy = Instantiate(randomEnemy, _enemyPos);
        }
    }

    public void SpawnHero()
    {
        for (int i = 0; i < 1; i++)
        {
            var randomHero = GetRandomUnit<BaseUnit>(Faction.Player);
            var spawnedHero = Instantiate(randomHero, _heroPos);
            _moveLogic._movePoint = spawnedHero.GetComponentInChildren<Transform>();
            spawnedHero.GetComponent<MoveLogic>();
        }
    }

    private T GetRandomUnit<T>(Faction faction) where T : BaseUnit
    {
        return (T)_units.Where(u => u._faction == faction).OrderBy(o => Random.value).First().GetRandomUnit();
    }
}
