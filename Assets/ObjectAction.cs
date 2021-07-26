using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    [SerializeField] float decreacetime = 5f;

    public void DecreaceTime(GameManager gameManager)
    {
        gameManager.DecreaceTimer(decreacetime);
    }
}
