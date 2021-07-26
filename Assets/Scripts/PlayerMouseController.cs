using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseController : MonoBehaviour
{
    private Vector3 pos;
    private Vector3 WorldPointPos;
    [SerializeField] AudioClip m_audioClip;
    AudioSource m_audioSource;


    // Start is called before the first frame update
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // マウスの位置座標をVector3で取得
        pos = Input.mousePosition;
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        WorldPointPos = Camera.main.ScreenToWorldPoint(pos);

        // y軸とz軸は固定
        WorldPointPos.y = 0.0f;
        WorldPointPos.z = 0.0f;

        // ワールド座標をPlayer位置へ変換
        gameObject.transform.position = new Vector3(WorldPointPos.x,transform.position.y,transform.position.z);

        
    }

    void OnTriggerEnter2D(Collider2D collision) // 衝突したとき
    {
        if (collision.gameObject.tag == "Item") // "Item"とtag付けした目標オブジェクトに衝突したら
        {
            IAction action = collision.gameObject.GetComponent<IAction>();
            if (action == null) return;

            action.Action();
            action.Inactivate();

            PlaySound();
        }
    }

    void PlaySound()
    {
        m_audioSource.PlayOneShot(m_audioClip);
    }
}
