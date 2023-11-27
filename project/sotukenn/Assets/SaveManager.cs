using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    // ゲームデータをセーブ/ロードするもの
    // ・セーブする形式を決める：true/falseの配列(アイテムを手に入れたかどうか)
    // ・セーブクラスを作成する：このセーブクラスを端末に保存したりする
    SaveData saveData;

    private void Start()
    {
        saveData = new SaveData();
        //saveData.getItem[0] = true;
        //Save();
        Load();
    }
    // ・セーブ関数を作る
    public void Save()
    {

        // SaveDataをJson化する:JsonUtility.ToJson
        // ・Json化：クラス(SaveData)を文字列(string)に変換する
        // ・PlayerPrefsを使って文字列を端末に保存する
        string json = JsonUtility.ToJson(saveData);
        PlayerPrefs.SetString("SAVE_DATA", json);
        Debug.Log(json);
    }

        // ・ロード関数を作る
    public void Load()
    {

        // PlayerPrefsを使って文字列を端末から取得する
        // 文字列をクラスに復元する:JsonUtility.ToJson
        string json = PlayerPrefs.GetString("SAVE_DATA");
        saveData = JsonUtility.FromJson<SaveData>(json);
        //Debug.Log(saveData.getItem[0]);
    }

    //アイテムを取得したら、取得したことをセーブする
    public void SetItemData()
    {
       // saveData.getItem[1] = true;
    }
}

[System.Serializable]
class SaveData
{
    bool[] getItem = new bool[2]; // アイテムを手に入れたかどうか
    
}
