using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    // �Q�[���f�[�^���Z�[�u/���[�h�������
    // �E�Z�[�u����`�������߂�Ftrue/false�̔z��(�A�C�e������ɓ��ꂽ���ǂ���)
    // �E�Z�[�u�N���X���쐬����F���̃Z�[�u�N���X��[���ɕۑ������肷��
    SaveData saveData;
    
    //static��:�ǂ�����ł��擾�ł���悤�ɂ���
    public static SaveManager instance;
    private void Awake()
    {
        instance = this;
        saveData = new SaveData();
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
        if(PlayerPrefs.HasKey("SAVE_DATA") == true)
        {
            // PlayerPrefs���g���ĕ������[������擾����
            // ��������N���X�ɕ�������:JsonUtility.ToJson
            string json = PlayerPrefs.GetString("SAVE_DATA");
            saveData = JsonUtility.FromJson<SaveData>(json);
            Debug.Log(saveData.getItem[0]);
        }

    }

    //�A�C�e�����擾������A�擾�������Ƃ��Z�[�u����
    public void SetItemData(Item.ItemType item)
    {
        int index = (int)item; //�񋓌^�𐔎��ɕϊ�
        saveData.getItem[index] = true;
        Save();
    }
    
    public bool GetItemData(Item.ItemType item)
    {
        int index = (int)item; //�񋓌^�𐔎��ɕϊ�
        return saveData.getItem[index];
    }


    //�A�C�e�����g�p������A�g�p�������Ƃ��Z�[�u����
    public void SetUseItemData(Item.ItemType item)
    {
        int index = (int)item; //�񋓌^�𐔎��ɕϊ�
        saveData.useItem[index] = true;
        Save();
    }
    
    public bool GetUseItemData(Item.ItemType item)
    {
        int index = (int)item; //�񋓌^�𐔎��ɕϊ�
        return saveData.useItem[index];
    }
}

[System.Serializable]
class SaveData
{
    public bool[] getItem = new bool[2]; // �A�C�e������ɓ��ꂽ���ǂ���
    public bool[] useItem = new bool[2]; // �A�C�e�����g�p�������ǂ���
    //public bool[] gimmick = new bool[2]; // �A�C�e������ɓ��ꂽ���ǂ���
}
