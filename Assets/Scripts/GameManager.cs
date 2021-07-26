using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// ゲームの状態
    /// </summary>
    enum State
    {
        CountDown,
        Stop,
        Finish,
    }
    /// <summary>
    /// ゲームの状態
    /// </summary>
    [SerializeField] State m_state = State.Stop;
    /// <summary>
    /// タイマーのゲージのイメージ
    /// </summary>
    [SerializeField] Image m_timerGageImg;
    /// <summary>
    /// 制限時間
    /// </summary>
    [SerializeField] float m_limitTime = 30;
    /// <summary>
    /// 制限時間
    /// </summary>
    public float LinmitTime{ get { return m_limitTime; } private set { } }
    /// <summary>
    /// タイマー
    /// </summary>
    public float Timer = 0;

    private void Start()
    {
        Timer = m_limitTime;
    }

    private void Update()
    {
        if (m_state == State.CountDown)
        {
            CountDown();
        }
    }
    
    /// <summary>
    /// カウントダウンする
    /// </summary>
    void CountDown()
    {
        Timer -= Time.deltaTime;

        //タイマーゲージを減らす
        m_timerGageImg.fillAmount = Timer / m_limitTime;

        //タイマーが0になったら終了する
        if (Timer <= 0)
        {
            CountFinish();
        }
    }

    /// <summary>
    /// タイマーを開始する
    /// </summary>
    public void CountStart()
    {
        m_state = State.CountDown;
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
