using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    // Start is called before the first frame update
    public string transitionName;
    void Start()
    {
        if (transitionName == PlayerController.instance.areaTransitionName)
        {
            PlayerController.instance.transform.position = transform.position;
        }
        UIFade.instance.FadeFromBlack();
        if (GameManager.instance != null)
        {
            GameManager.instance.fadingBetweenAreas = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
