using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    public static float CountDownTime; // カウントダウンタイム
    public Text TextCountDown; // 表示用テキストUI

    void Start()
    {
        CountDownTime = 30.0F;    // カウントダウン開始秒数をセット
    }

    void Update()
    {
        // カウントダウンタイムを整形して表示
        TextCountDown.text = string.Format("Time: {0:00.00}", CountDownTime);
        // 経過時刻を引いていく
        CountDownTime -= Time.deltaTime;

        if (CountDownTime <= 0.0F)
        {
            SceneManager.LoadScene("GameClear");
        }


    }
}