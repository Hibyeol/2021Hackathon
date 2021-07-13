using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ese : MonoBehaviour
{
    public GameObject eseImgae;
    
    // Start is called before the first frame update
    void Start()
    {
        eseImgae = transform.Find("Ese").gameObject;
        eseImgae.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            eseImgae.SetActive(true);
        }    
    }
}
