using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //�e�p�l�����擾
    public GameObject lightStandPanel;
    public GameObject drawerPanel;
    public GameObject pcPanel;

    //�{�^������������Y������p�l����\��
    public void OnClickLightStandTrigger()
    {
        lightStandPanel.SetActive(true);
    }
}
