using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerController : MonoBehaviour
{
    //カウントダウン
    [SerializeField]
    private float countdown = 30f;

    //時間を表示するText型の変数
    public Text timeText;

    void FixedUpdate()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        timeText.text = countdown.ToString("f3");

        if(countdown < 10)
        {
            timeText.text = timeText.text.Insert(0, "0"); 
        }
        //カウントが0秒になった時
        if(countdown <= 0)
        {
            //カウント止める
            countdown = 0;
            timeText.text = "0";
            
        }
    }
}
//SS.CCC
//SS"CCC
