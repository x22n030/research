using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    //必要な要素
    //Boxそれぞれの画像情報
    public GameObject[] boxs;
    
    public void Start ()
    {
        public void SetItem()
        {
            boxs[0].SetActive(false);
            boxs[1].SetActive(false);
            boxs[2].SetActive(false);
            boxs[3].SetActive(false);
            boxs[4].SetActive(false);

            SetItem();
            UseItem();

        }


        //処理
        //アイテムがクリックされた時に、そのアイテム画像をアイテムBoxに表示する
        public void SetItem()
    {
        boxs[0].SetActive(true);

    }
    //アイテムが使えるかどうかを調べる（アイテムBoxに存在するか調べる）
    bool CanUseItem()
        {
            //画像が表示されていれば使える
            if(boxs[0].activeSelf == true)
            {
                return true;
            }
            return false;
        }
    //アイテムを使うときに、そのアイテム画像をBoxから非表示にする

    public void UseItem()
        {
            boxs[0].SetActive(false);
        }
}
