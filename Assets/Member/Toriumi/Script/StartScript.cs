using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class StartScript : MonoBehaviour
{
    [SerializeField]
    float flashSpeed;               // �������ł�����΂ł����قǓ_�ł������Ȃ��

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

        // Sin��-1�`1��Ԃ���ł�Color��0�`1�Ŏw�肷���
        // ������0.5������0.5�����Ă��
        color.a = Mathf.Sin(_time) * 0.5f + 0.5f;

        _text.color = color;


        // �V�[���J�ڂ̓z�B�K�v�Ȏg����
        // �������甽������̂�Down�BanyKey�͂��̖��̒ʂ艽�ł���k
        // �}�E�X�̔����Ȃ����̂��㔼�̓z�B�����Ȃ��ł����Ȃ�R�[�h�������Ƃ���
        if (Input.anyKeyDown && !Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2))
        {
            SceneManager.LoadScene("MusicSelectScene");
        }
    }
}
