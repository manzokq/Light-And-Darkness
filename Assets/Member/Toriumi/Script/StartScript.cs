using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class StartScript : MonoBehaviour
{
    [SerializeField]
    float flashSpeed;               // 数字がでかければでかいほど点滅が早くなるよ

    private TextMeshProUGUI _text;

    private float _time;

    // Start is called before the first frame update
    void Start()
    {
        _text = gameObject.GetComponent<TextMeshProUGUI>();
        _time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Color color = _text.color;

        _time += Time.deltaTime * flashSpeed;

        // Sinは-1～1を返すよでもColorは0～1で指定するよ
        // だから0.5かけて0.5足してるよ
        color.a = Mathf.Sin(_time) * 0.5f + 0.5f;

        _text.color = color;


        // シーン遷移の奴。必要な使って
        // 押したら反応するのがDown。anyKeyはその名の通り何でもおk
        // マウスの反応なくすのが後半の奴。消さないでいいならコードを消しといて
        if (Input.anyKeyDown && !Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2))
        {
            SceneManager.LoadScene("MusicSelectScene");
        }
    }
}
