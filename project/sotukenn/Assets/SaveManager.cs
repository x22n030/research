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
        string json = JsonUtility.ToJson(saveData);
        PlayerPrefs.SetString("SAVE_DATA", json);
        Debug.Log(json);
    }

        // �E���[�h�֐������
    public void Load()
    {

        // PlayerPrefs���g���ĕ������[������擾����
        // ��������N���X�ɕ�������:JsonUtility.ToJson
        string json = PlayerPrefs.GetString("SAVE_DATA");
        saveData = JsonUtility.FromJson<SaveData>(json);
        //Debug.Log(saveData.getItem[0]);
    }

    //�A�C�e�����擾������A�擾�������Ƃ��Z�[�u����
    public void SetItemData()
    {
       // saveData.getItem[1] = true;
    }
}

[System.Serializable]
class SaveData
{
    bool[] getItem = new bool[2]; // �A�C�e������ɓ��ꂽ���ǂ���
    
}
