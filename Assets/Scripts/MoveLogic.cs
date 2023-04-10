using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MoveLogic : MonoBehaviour
{
    [SerializeField] public Transform _movePoint;
    [SerializeField] private Button _left;
    [SerializeField] private Button _right;
    [SerializeField] private Button _up;
    [SerializeField] private Button _down;


    private float _moveSpeed = 2.5f;
    
    private void OnEnable()
    {
        _left.onClick.AddListener(OnLeftButton);
        _right.onClick.AddListener(OnRightButton);
        _up.onClick.AddListener(OnUpButton);
        _down.onClick.AddListener(OnDownButton);
    }

    private void OnDisable()
    {
        _left.onClick.RemoveListener(OnLeftButton);
        _right.onClick.RemoveListener(OnRightButton);
        _up.onClick.RemoveListener(OnUpButton);
        _down.onClick.RemoveListener(OnDownButton);
    }



    private void Start()
    {
        _movePoint.parent = null;
    }           

    public void OnLeftButton()
    {
        Vector3 newPos = _movePoint.position += new Vector3(-2.5f, 0f, 0f);
        transform.DOMove(newPos, _moveSpeed);
    }

    public void OnRightButton()
    {        
        Vector3 newPos = _movePoint.position += new Vector3(2.5f, 0f, 0f);
        transform.DOMove(newPos, _moveSpeed);
    }

    private void OnUpButton()
    {
        Vector3 newPos = _movePoint.position += new Vector3(0f, 2.5f, 0f);
        transform.DOMove(newPos, _moveSpeed);
    }

    private void OnDownButton()
    {
        Vector3 newPos = _movePoint.position += new Vector3(0f, -2.5f, 0f);
        transform.DOMove(newPos, _moveSpeed);
    }

    //private void Update()
    //{
    //    transform.position = Vector3.MoveTowards(transform.position, _movePoint.position, _moveSpeed * Time.deltaTime);        

    //    if (Vector3.Distance(transform.position, _movePoint.position) <= .05f)
    //    {
    //        if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1)
    //            _movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);

    //        if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1)
    //            _movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
    //    }

    //}
}
