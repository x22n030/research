using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tana : MonoBehaviour
{
    //*棚をクリックしたときにplayerがkey(鍵)を持っていれば消える
    //　・タイミング :棚をクリックしたとき
    //　・処理 :消える
    //　・条件 :playerがkeyを持っている

    private void Start()
    {
        //すでにLeafを使っていれば消える
        bool useItem = SaveManager.instance.GetUseItemData(Item.ItemType.Leaf);
        if(useItem == true)
        {
            ItemBox.instance.UseItem(Item.ItemType.Leaf);
            gameObject.SetActive(false);
        }
    }

    //　・タイミング :棚をクリックしたとき : ボタンのOnClickで実装
    public void OnThis()
    {
    //　・条件 :playerがkeyを持っている : if文で実装
        bool hasItem = ItemBox.instance.CanUseItem(Item.ItemType.Leaf); //TODO:ItemBoxの実装
        if (hasItem == true) //TODO:Itemの実装
        {
            //　・処理 :消える :SetActiveで実装
            gameObject.SetActive(false);
            // アイテムを使う
            ItemBox.instance.UseItem(Item.ItemType.Leaf);
        }

    }



}
