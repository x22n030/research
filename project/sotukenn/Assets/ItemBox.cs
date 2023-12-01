/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{   
    //必要な要素
    //Boxそれぞれの画像情報
    public GameObject[] boxs;


    //このクラスは他のどのファイルでも使いたい
    //static化 : どこからでも取得できるようにする
    public static ItemBox instance;
    private void Awake()
    {
        instance = this;
    }
    
    public void Start ()
    {
        
        boxs[0].SetActive(false);
        boxs[1].SetActive(false);
        boxs[2].SetActive(false);
        boxs[3].SetActive(false);
        boxs[4].SetActive(false);
    }


        //処理
        //アイテムがクリックされた時に、そのアイテム画像をアイテムBoxに表示する
        public void SetItem(ItemType item)
    {
        int index = (int)item;
        boxs[index].SetActive(true);

    }
    //アイテムが使えるかどうかを調べる（アイテムBoxに存在するか調べる）
    public bool CanUseItem(Item.ItemType item)
        {
        int index = (int)item;
            //画像が表示されていれば使える
            if(boxs[index].activeSelf == true)
            {
                return true;
            }
            return false;
        }
    //アイテムを使うときに、そのアイテム画像をBoxから非表示にする

    public void UseItem(Item.ItemType item)
        {
            int index = (int)item;
            boxs[index].SetActive(false);
        }
}*/
