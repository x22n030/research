using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ITEM
{
    NONE,
    LIGHT_BULB
}

public class ItemBoxManager : MonoBehaviour
{
    [SerializeField] Sprite lightBulbSprite; //�d���摜
    [SerializeField] Image[] itemBoxImages;
    [SerializeField] LightStandManager lightStandManager;


    ITEM[] itemList = new ITEM[4]; //�擾�����A�C�e���̔z��

    //�A�C�e�����擾
    public void SetItem(ITEM item)
    {
        itemList[0] = item;
        switch (item)
        {
            case ITEM.LIGHT_BULB:
                itemBoxImages[0].sprite = lightBulbSprite;
                break;

            case ITEM.NONE:
                itemBoxImages[0].sprite = null;
                break;
        }
       
    }

    //�A�C�e���̎g�p
    public void UseItem(int index)
    {
        switch (itemList[index])
        {
            case ITEM.LIGHT_BULB:
                lightStandManager.LightSwitch(true);
                break;
            default:
                break;
        }
        itemList[index] = ITEM.NONE; //�A�C�e�����g�p�����̂ŋ�ɂȂ�
        itemBoxImages[index].sprite = null;
    }
}
