using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// ゲームの状態
    /// </summary>
    enum State
    {
        CountUp,
        Stop,
        Finish,
    }
    /// <summary>
    /// ゲームの状態
    /// </summary>
    [SerializeField] State m_state = State.Stop;

    /// <summary>
    /// 制限時間
    /// </summary>
    [SerializeField] float m_limitTime = 30;
    /// <summary>
    /// タイマー
    /// </summary>
    float m_timer = 0;

    private void Start()
    {
        m_timer = m_limitTime;
    }

    private void Update()
    {
        if (m_state == State.CountUp)
        {
            m_timer -= Time.deltaTime;
            Debug.Log((int)m_timer);
            
            //タイマーが0になったら終了する
            if (m_timer <= 0)
            {
                CountFinish();
            }
        }
    }

    /// <summary>
    /// タイマーを開始する
    /// </summary>
    public void CountStart()
    {
        m_state = State.CountUp;
    }

    /// <summary>
    /// タイマーを停止する
    /// </summary>
    public void CountStop()
    {
        m_state = State.Stop;
    }

    /// <summary>
    /// タイマーを終了する
    /// </summary>
    void CountFinish()
    {
        m_state = State.Finish;
    }
}
