using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveButtons : MonoBehaviour
{
    [SerializeField] private Button _left;
    [SerializeField] private Button _right;
    [SerializeField] private Button _up;
    [SerializeField] private Button _down;

    public void Init(Button left, Button right, Button up, Button down)
    {
        _left = left;
        _right = right;
        _up = up;
        _down = down;
    }
}
