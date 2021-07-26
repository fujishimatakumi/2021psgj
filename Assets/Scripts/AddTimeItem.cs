using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 時間を加算するアイテム
/// </summary>
public class AddTimeItem : MonoBehaviour, IAction
{
    /// <summary>
    /// 加算される時間
    /// </summary>
    [SerializeField] float m_addTime;

    public void Action(GameManager gameManager)
    {
        //加算された時、制限時間を超えなかったら
        if (gameManager.Timer + m_addTime <= gameManager.LinmitTime)
        {
            //普通に時間を加算させる
            gameManager.Timer += m_addTime;
        }
        //加算された時、制限時間を超えたら
        else
        {
            //制限時間より多くならないように加算させる
            gameManager.Timer += gameManager.LinmitTime - gameManager.Timer;
        }
    }

    public void Inactivate()
    {
        gameObject.SetActive(false);
    }
}
