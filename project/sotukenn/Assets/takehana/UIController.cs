using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    Text gameover_text;

    private bool enemyTouch;


    // Start is called before the first frame update
    void Start()
    {
        gameover_text = GameObject.Find("gameoverText").GetComponent<Text>();

        gameover_text.enabled = false;

        enemyTouch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyTouch == true)
        {
            GameOverMessage();
        }
    }

    public bool EnemyTouch
    {
        get { return enemyTouch; }
        set { enemyTouch = value; }

    }

    void GameOverMessage()
    {
        gameover_text.enabled = true;
    }
}
