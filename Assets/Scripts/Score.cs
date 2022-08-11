using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    public static float CountDownTime; // �J�E���g�_�E���^�C��
    public Text TextCountDown; // �\���p�e�L�X�gUI

    void Start()
    {
        CountDownTime = 47.0F;    // �J�E���g�_�E���J�n�b�����Z�b�g
    }

    void Update()
    {
        // �J�E���g�_�E���^�C���𐮌`���ĕ\��
        TextCountDown.text = string.Format("Time: {0:00.00}", CountDownTime);
        // �o�ߎ����������Ă���
        CountDownTime -= Time.deltaTime;

        if (CountDownTime <= 0.0F)
        {
            SceneManager.LoadScene("GameClear");
        }


    }
}