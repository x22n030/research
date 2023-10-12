using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;  //�@�����������I�u�W�F�N�g���C���X�y�N�^�[��������B
    public int speed = 5;  //�I�u�W�F�N�g�������œ����X�s�[�h����
    Vector3 movePosition;  //�A�I�u�W�F�N�g�̖ړI�n��ۑ�

    void Start()
    {
        movePosition = moveRandomPosition();  //�A���s���A�I�u�W�F�N�g�̖ړI�n��ݒ�
    }

    void Update()
    {
        if (movePosition == player.transform.position)  //�Aplayer�I�u�W�F�N�g���ړI�n�ɓ��B����ƁA
        {
            movePosition = moveRandomPosition();  //�A�ړI�n���Đݒ�
        }
        this.player.transform.position = Vector3.MoveTowards(player.transform.position, movePosition, speed * Time.deltaTime);  //�@�Aplayer�I�u�W�F�N�g��, �ړI�n�Ɉړ�, �ړ����x
    }

    private Vector3 moveRandomPosition()  // �ړI�n�𐶐��Ax��y�̃|�W�V�����������_���ɒl���擾 
    {
        Vector3 randomPosi = new Vector3(Random.Range(-7, 7), Random.Range(-4, 4), 5);
        return randomPosi;
    }
}