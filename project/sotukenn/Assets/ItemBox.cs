/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{   
    //�K�v�ȗv�f
    //Box���ꂼ��̉摜���
    public GameObject[] boxs;


    //���̃N���X�͑��̂ǂ̃t�@�C���ł��g������
    //static�� : �ǂ�����ł��擾�ł���悤�ɂ���
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


        //����
        //�A�C�e�����N���b�N���ꂽ���ɁA���̃A�C�e���摜���A�C�e��Box�ɕ\������
        public void SetItem(ItemType item)
    {
        int index = (int)item;
        boxs[index].SetActive(true);

    }
    //�A�C�e�����g���邩�ǂ����𒲂ׂ�i�A�C�e��Box�ɑ��݂��邩���ׂ�j
    public bool CanUseItem(Item.ItemType item)
        {
        int index = (int)item;
            //�摜���\������Ă���Ύg����
            if(boxs[index].activeSelf == true)
            {
                return true;
            }
            return false;
        }
    //�A�C�e�����g���Ƃ��ɁA���̃A�C�e���摜��Box�����\���ɂ���

    public void UseItem(Item.ItemType item)
        {
            int index = (int)item;
            boxs[index].SetActive(false);
        }
}*/
