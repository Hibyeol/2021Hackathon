using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonM : MonoBehaviour
{
    public SceanM ScM;

    
    public GameObject fix;

    public GameM gM;

    public lovePower lovP;

    public Ese ese;
 
    private void Start()
    {
        ese = FindObjectOfType <Ese>();
        gM = FindObjectOfType<GameM>();
        lovP = new lovePower();
    }

    public void NewStartGame()
    {
        lovP.NewStart();
        ScM.StartG();
    }
    public void CountinueG()
    {
        ScM.ContG();
    }
    public void QuitGame()
    {
        ScM.QuitGame();
    }
    public void Fixed()
    {
        fix.SetActive(true);    
    }
    public void FIrS()
    {
        ScM.FirstG();
    }
    public void Nclick()
    {
        gM.Nspeak();
    }
    public void Sclick()
    {
        gM.Sspeak();
    }
    public void Pclick()
    {
        gM.Pspeak();
    }
    public void Gclick()
    {
        gM.Gspeak();
    }
    public void EseCount()
    {
        ese.eseImgae.SetActive(false);
    }
    public void FixOut()
    {
        fix.SetActive(false);
    }
    public void Save()
    {
        lovP.NlovePower();
        Debug.Log("저장~");
    }
  
}
