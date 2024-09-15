using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Gamecontroller : MonoBehaviour
{
    public GameObject Button;
    public GameObject Singing;
    public GameObject Dancing;
    public GameObject WelcomeImage;
    public GameObject Hello;
    public GameObject crying;
    public GameObject HelloImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Welcome()
    {
            Button.SetActive(false);
            WelcomeImage.SetActive(false);
            Hello.SetActive(true);
            crying.SetActive(true);
            HelloImage.SetActive(true);
            Singing.SetActive(true);
            Dancing.SetActive(true);      
    }
   

    public void Close()
    {
        Application.Quit();
    }
}
