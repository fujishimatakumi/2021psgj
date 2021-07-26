using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    [SerializeField] float decreacetime = 5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager gamemanager = FindObjectOfType<GameManager>();
            gamemanager.DecreaceTimer(decreacetime);
        }
    }
}
