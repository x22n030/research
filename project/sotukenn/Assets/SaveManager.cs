using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    // �Q�[���f�[�^���Z�[�u/���[�h�������
    // �E�Z�[�u����`�������߂�Ftrue/false�̔z��(�A�C�e������ɓ��ꂽ���ǂ���)
    // �E�Z�[�u�N���X���쐬����F���̃Z�[�u�N���X��[���ɕۑ������肷��
    SaveData saveData;

    private void Start()
    {
        saveData = new SaveData();

        //saveData.getItem[0] = true;
        //Save();
        Load();
    }
    // �E�Z�[�u�֐������
    public void Save()
    {
       
        // SaveData��Json������:JsonUtility.ToJson
        // �EJson���F�N���X(SaveData)�𕶎���(string)�ɕϊ�����
        // �EPlayerPrefs���g���ĕ������[���ɕۑ�����

    }

    // �E���[�h�֐������
    public void Load(int level)
    {

        // PlayerPrefs���g���ĕ������[������擾����
        // ��������N���X�ɕ�������:JsonUtility.ToJson
    }
}

class SaveData
{
    bool[] getItem = new bool[]; // �A�C�e������ɓ��ꂽ���ǂ���
    
}
