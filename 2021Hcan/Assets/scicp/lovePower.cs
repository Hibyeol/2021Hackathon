using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class lovePower 
{
    public static int Nlove = 0;//내신 호감도(변강순쌤)
    public static int Slove = 0;//임베디드
    public static int Plove = 0;//포토플리오
    public static int Glove = 0;//기능반
    public static int month = 3;//1,2,월(달)
    public static int Ground = 1;//학년

    public void NlovePower()
    {

        Nlove++;
        monthPluis();
        Debug.Log("N: " +Nlove);
    }
    public void SlovePower()
    {
        Slove++;
        monthPluis();
        Debug.Log("S: " + Slove);
    }
    public void GlovePower()
    {
        Glove++;
        monthPluis();
        Debug.Log("G: " + Glove);
    }
    public void PlovePower()
    {
        Plove++;
        monthPluis();
        Debug.Log("P: " + Plove);
    }

    public void monthPluis()
    {
        month++;
        if (month > 12)
        {
            Ground++;
            month = 3;
        }
        Debug.Log("M: " + month);
    }
    public void NewStart()
    {
        Nlove = 0;
        Slove = 0;
        Plove = 0;
        Glove = 0;
        month = 3;
        Ground = 1;

    }
}
