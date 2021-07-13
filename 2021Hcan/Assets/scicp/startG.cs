using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startG : MonoBehaviour
{
    public GameM gM;
    public int gameing=0;
    public bool speaking = true;
    
    void Start()
    {
        gM = FindObjectOfType<GameM>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameing)
        {
            case 0:
                if (speaking == true)
                {
                    gM.Speak0();
                    speaking = false;
                }
                else if (speaking == false && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))){
                    speaking = true;
                    gameing = 1;
                }
                break;
            case 1:
                if (speaking == true)
                {
                    gM.Speak1();
                    speaking = false;
                }
                else if (speaking == false && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))){
                    speaking = true;
                    gameing = 2;
                }
                break;
            case 2:
                if (speaking == true)
                {
                    gM.Speak2();
                    speaking = false;
                }
                else if (speaking == false && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
                {
                    speaking = true;
                    gameing = 3;
                }
                break;
            case 3:
                if (speaking == true)
                {
                    gM.QandA.SetActive(true);
                    gM.clickOn = false;
                    Debug.Log("?: "+ gM.clickOn);
                    speaking = false;
                }
                else if(gM.clickOn==true)
                {
                    gameing = 4;
                    speaking = true;
                }
                
                break;
        }
    }

}
