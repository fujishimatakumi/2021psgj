using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundManager : MonoBehaviour
{
    [SerializeField] GameObject[] _stages;
    [SerializeField] Vector3 _startPos;
    [SerializeField] Vector3 _nextPos;
    GameObject _nowMoveObject;
    float _startYFront;
    float _startYEnd;
    float _nowYFront;
    float _nowYEnd;
    int _index;
    [SerializeField] float _delay = 6f;
    [SerializeField] float _scoreMag;

    [SerializeField] Text _text;
    float _score;
    public float Score => _score;
    [SerializeField] bool _isMove;
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (_isMove)
        {
            _score += _scoreMag;
            _text.text = "Score:" + string.Format("{0,6}", (int)_score);
        }

        _nowYFront = _nowMoveObject.transform.position.y - (_nowMoveObject.transform.localScale.y / 2);

        if (_nowYFront <= _startYFront)
        {
            SetNextStage();
        }
    }
    void Init()
    {
        GameObject stage = Instantiate(_stages[0]);
        _index = 1;
        _nowMoveObject = stage;
        stage.SetActive(true);
        stage.transform.position = _startPos;

        SpriteRenderer renderer = stage.GetComponent<SpriteRenderer>();
        _startYFront = stage.transform.position.y - (stage.transform.localScale.y / 2);
        _startYEnd = stage.transform.position.y + (stage.transform.localScale.y / 2);
    }

    void SetNextStage()
    {
        _index = (_index + 1) % _stages.Length;
        GameObject nextStage = Instantiate(_stages[_index]);
        nextStage.transform.position = _nextPos;
        GameObject destroyobj = _nowMoveObject;
        _nowMoveObject = nextStage;
        nextStage.SetActive(true);
        StartCoroutine(DestoryDelay(destroyobj));
    }

    IEnumerator DestoryDelay(GameObject obj)
    {
        yield return new WaitForSeconds(_delay);
        Destroy(obj);
    }

    public void StopAddScore()
    {
        _isMove = false;
    }
    public void StartAddScore()
    {
        _isMove = true;
    }

    public void ChangeSpeedObject()
    {
        foreach (var item in _stages)
        {
            ObjectSclole os = item.GetComponent<ObjectSclole>();
            os.ChangeSpeed();
        }
    }
}
