using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public GameState gameState;
    public void ChangeState(GameState newState)
    {
    }

    
}

public enum GameState
{
    GenerateGrid,
    SpawnUnits,
    HeroTurn,
    EnemyTurn,
    Fight
}
