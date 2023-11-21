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

    }

    // ・ロード関数を作る
    public void Load(int level)
    {

        // PlayerPrefsを使って文字列を端末から取得する
        // 文字列をクラスに復元する:JsonUtility.ToJson
    }
}

class SaveData
{
    bool[] getItem = new bool[]; // アイテムを手に入れたかどうか
    
}
