using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // �C���X�y�N�^�r���[����ݒ肷��V�[����
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// �C���X�y�N�^�r���[����ݒ肵���V�[����ǂݍ���
    /// <summary>
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}