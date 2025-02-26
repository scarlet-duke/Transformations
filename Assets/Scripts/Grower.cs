using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grower : MonoBehaviour
{

    [SerializeField] private Vector3 _scale;

    private void Update()
    {
        transform.localScale += _scale * Time.deltaTime;
    }
}
