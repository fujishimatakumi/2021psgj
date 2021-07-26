using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeedData : MonoBehaviour
{
    [SerializeField] float _speed = 0.02f;
    public float Speed => _speed;

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }

    public void AddSpeed(float speed)
    {
        _speed += speed;
    }
}
