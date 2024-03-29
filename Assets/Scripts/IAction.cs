﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAction 
{
    /// <summary>
    /// アイテムの効果を発動させる
    /// </summary>
    void Action(GameManager gameManager);

    /// <summary>
    /// アイテムを見えなくする
    /// </summary>
    void Inactivate();
}
