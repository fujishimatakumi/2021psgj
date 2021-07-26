using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// アイテム
/// </summary>
public class Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("アイテムにあったった");
        }
    }
}
