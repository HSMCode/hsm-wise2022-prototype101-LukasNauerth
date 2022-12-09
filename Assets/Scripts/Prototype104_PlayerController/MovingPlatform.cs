using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
[SerializeField] private Transform _targetA, _targetB;
[SerializeField] private float _speed = 3.0f;
private bool _switching = false;

   void FixedUpdate()
   {
    if (!_switching)
    {
        transform.position = Vector3.MoveTowards(transform.position,_targetB.position, _speed * Time.fixedDeltaTime);
    }
    else if (_switching)
    {
        transform.position = Vector3.MoveTowards(transform.position,_targetA.position, _speed * Time.fixedDeltaTime);
    }
    if(transform.position == _targetB.position)
    {
        _switching = true;
    }
    else if (transform.position == _targetA.position)
    {
        _switching =false;
    }
   }
}
