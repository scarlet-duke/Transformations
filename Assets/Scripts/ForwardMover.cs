using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    private int _speed = 5;
    private void Update()
    {
        transform.position += Vector3.forward * _speed * Time.deltaTime;
    }
}
