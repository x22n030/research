using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerManager : MonoBehaviour
{
    [SerializeField] GameObject lightBulbPanel;
    [SerializeField] GameObject alertText;
    [SerializeField] ItemBoxManager ItemBoxManager;

    // Start is called before the first frame update
    void Start()
    {
        LightBulbSetActive(false);
    }

    void LightBulbSetActive(bool isShow)
    {
        lightBulbPanel.SetActive(isShow);
        alertText.SetActive(isShow);
    }
    //�����o���������ꂽ��
    //1.�d���̉摜���o��
    //2.Text���o��

    public void OnClickTrigger()
    {
        LightBulbSetActive(true);
        ItemBoxManager.SetItem(ITEM.LIGHT_BULB);
    }

    //�d���̉摜���N���b�N����Ɠd���摜���\���ɂ���
    public void OnClickImage()
    {
        LightBulbSetActive(false);
    }

}
