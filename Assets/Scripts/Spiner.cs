using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spiner : MonoBehaviour
{
    [SerializeField] private float _angle;
    private int _fullTurn = 360;

    private void Update()
    {
        transform.Rotate(0, _angle * Time.deltaTime * _fullTurn, 0);
    }
}
