using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //複数アイテムの実装
    //必要なアイテムを列挙する
    public enum ItemType
    {
        Leaf = 0,
        Key = 1,
        Sample = 2,
    }
    public ItemType item; //このアイテムが何なのか

    //クリックされたら、非表示になってアイテムBoxに追加される
    //タイミング：クリックされたら
    //処理：
    //非表示
    //アイテムBoxへ追加

    private void Start()
    {
        //セーブデータを確認して、すでに持っていれば消す
        bool hasThisItem = SaveManager.instance.GetItemData(item);
        if(hasThisItem == true)
        {
            gameObject.SetActive(false);

            ItemBox.instance.SetItem(item);
        }
        
    }


    //タイミング：クリックされたら
    public void OnThis()
    {
        //非表示
        gameObject.SetActive(false);
        // アイテムBoxへ追加:
        ItemBox.instance.SetItem(item);


    }

}
