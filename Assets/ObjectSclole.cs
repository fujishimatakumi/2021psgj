using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSclole : MonoBehaviour
{
    [SerializeField] float _scloleSpeed = 2f;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Vector2.down * _scloleSpeed);
    }
}
