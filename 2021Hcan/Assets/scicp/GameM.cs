using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameM : MonoBehaviour
{
    public Text speak;
    public Text who;
    public Image whoImage;
    public Sprite[] change;
    public GameObject canves;
    public GameObject QandA;
    public bool clickOn=false;
    public lovePower loveP;
    
    

    void Start()
    {
        loveP = new lovePower();
        canves = GameObject.Find("Canvas");
        whoImage = canves.transform.Find("whoIm").gameObject.GetComponent<Image>();
        speak = canves.transform.Find("Speak").gameObject.GetComponent<Text>();
        who = canves.transform.Find("Whoname").gameObject.GetComponent<Text>();
        QandA = canves.transform.Find("Answer").gameObject;
        QandA.SetActive(false);
    }

    // Update is called once per frame
    public void Speak0()
    {
        whoImage.sprite = change[0];
        who.text = "김";
        speak.text = "<size=50>안녕하세요"+"\n"+"반가워요</size>";
    }
    public void Speak1()
    {
        whoImage.sprite = change[1];
        who.text = "지";
        speak.text = "안녕하세요2";
    }
    public void Speak2()
    {
        whoImage.sprite = change[2];
        who.text = "경";
        speak.text = "안녕하세요3";
    }

    public void Nspeak()
    {
        QDIe();
        whoImage.sprite = change[0];
        who.text = "내신";
        speak.text = "내신하실?";
        loveP.NlovePower();
    }
    public void Pspeak()
    {
        QDIe();
        whoImage.sprite = change[2];
        who.text = "포톨";
        speak.text = "포톨하실?";
        loveP.PlovePower();
    }
    public void Gspeak()
    {
        QDIe();
        whoImage.sprite = change[2];
        who.text = "기능";
        speak.text = "기능하실?";
        loveP.GlovePower();
    }
    public void Sspeak()
    {
        QDIe();
        whoImage.sprite = change[2];
        who.text = "임베";
        speak.text = "임베하실?";
        loveP.SlovePower();
       
    }

    public void QDIe()
    {
       
        QandA.SetActive(false);
        clickOn = true;
    }
}
