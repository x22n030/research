using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PANEL
{
    ROOM,
    LIGHT_STAND,
    DRAWER,
    PC
}


public class GameManager : MonoBehaviour
{
    //�e�p�l�����擾
    public GameObject lightStandPanel;
    public GameObject drawerPanel;
    public GameObject pcPanel;

    //���ݕ\�����Ă���p�l��
    public PANEL currentPanel = PANEL.ROOM; //�V��2:12�̂Ƃ�

    
    //�{�^������������Y������p�l����\��
    public void OnClickLightStandTrigger()
    {
        lightStandPanel.SetActive(true);
    }

    public void OnClickDrawerTrigger()
    {
        drawerPanel.SetActive(true);
    }

    public void OnClickPCTrigger()
    {
        pcPanel.SetActive(true);
    }

    //�{�^������������p�l�������ׂĔ�\���ɂ���
    public void OnClickBackTrigger()
    {
        lightStandPanel.SetActive(false);
        drawerPanel.SetActive(false);
        pcPanel.SetActive(false);
    }

}
