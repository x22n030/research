using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tana : MonoBehaviour
{
    //*�I���N���b�N�����Ƃ���player��key(��)�������Ă���Ώ�����
    //�@�E�^�C�~���O :�I���N���b�N�����Ƃ�
    //�@�E���� :������
    //�@�E���� :player��key�������Ă���

    private void Start()
    {
        //���ł�Leaf���g���Ă���Ώ�����
        bool useItem = SaveManager.instance.GetUseItemData(Item.ItemType.Leaf);
        if(useItem == true)
        {
            ItemBox.instance.UseItem(Item.ItemType.Leaf);
            gameObject.SetActive(false);
        }
    }

    //�@�E�^�C�~���O :�I���N���b�N�����Ƃ� : �{�^����OnClick�Ŏ���
    public void OnThis()
    {
    //�@�E���� :player��key�������Ă��� : if���Ŏ���
        bool hasItem = ItemBox.instance.CanUseItem(Item.ItemType.Leaf); //TODO:ItemBox�̎���
        if (hasItem == true) //TODO:Item�̎���
        {
            //�@�E���� :������ :SetActive�Ŏ���
            gameObject.SetActive(false);
            // �A�C�e�����g��
            ItemBox.instance.UseItem(Item.ItemType.Leaf);
        }

    }



}
