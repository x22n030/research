using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    //�K�v�ȗv�f
    //Box���ꂼ��̉摜���
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


        //����
        //�A�C�e�����N���b�N���ꂽ���ɁA���̃A�C�e���摜���A�C�e��Box�ɕ\������
        public void SetItem()
    {
        boxs[0].SetActive(true);

    }
    //�A�C�e�����g���邩�ǂ����𒲂ׂ�i�A�C�e��Box�ɑ��݂��邩���ׂ�j
    bool CanUseItem()
        {
            //�摜���\������Ă���Ύg����
            if(boxs[0].activeSelf == true)
            {
                return true;
            }
            return false;
        }
    //�A�C�e�����g���Ƃ��ɁA���̃A�C�e���摜��Box�����\���ɂ���

    public void UseItem()
        {
            boxs[0].SetActive(false);
        }
}
