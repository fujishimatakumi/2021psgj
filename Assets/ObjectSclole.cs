using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSclole : MonoBehaviour
{
    [SerializeField] float _scloleSpeed = 2f;
    MoveSpeedData _speedData;
    // Start is called before the first frame update
    private void Start()
    {
        _speedData = FindObjectOfType<MoveSpeedData>();
        _scloleSpeed = _speedData.Speed;
    }
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Vector2.down * _scloleSpeed);
    }

    public void ChangeSpeed()
    {
        _scloleSpeed = _speedData.Speed;
    }
}
