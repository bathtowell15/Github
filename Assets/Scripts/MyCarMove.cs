using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCarMove : MonoBehaviour
{
    [SerializeField] private float speed;//�v���C���[�̈ړ����x
    [SerializeField] private float maxY, minY; //�ړ��͈͂̐���

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(); //�v���C���[�𓮂������\�b�h���Ăяo��
    }


    void MovePlayer()
    {
        //��������L�[�������ꂽ��
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            Vector3 playerPos = transform.position; //Vector3�^��playerPos�Ɍ��݂̈ʒu�����i�[
            playerPos.y += speed * Time.deltaTime; //y���W��speed�����Z

            //�ǉ�
            //����playerPos��Y���W��maxY�i�ő�Y���W�j���傫���Ȃ�����
            if (maxY < playerPos.y)
            {
                playerPos.y = maxY; //PlayerPos��Y���W��maxY����
            }
            transform.position = playerPos; //���݂̈ʒu���ɔ��f������

        }
        else if (Input.GetAxisRaw("Vertical") < 0)�@//���������L�[�������ꂽ��
        {
            Vector3 playerPos = transform.position;
            playerPos.y -= speed * Time.deltaTime;

            //�ǉ�
            if (minY > playerPos.y)
            {
                playerPos.y = minY;
            }
            transform.position = playerPos;
        }
    }
}
