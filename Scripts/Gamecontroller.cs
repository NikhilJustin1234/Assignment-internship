//using System.Collections;
//using System.Collections.Generic;
//using TMPro;
//using UnityEngine;
//using UnityEngine.UIElements;

//public class Gamecontroller : MonoBehaviour
//{
//    public GameObject Button;
//    public GameObject Singing;
//    public GameObject Dancing;
//    public GameObject WelcomeImage;
//    public GameObject Hello;
//    public GameObject crying;
//    public GameObject HelloImage;
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//    public void Welcome()
//    {
//            Button.SetActive(false);
//            WelcomeImage.SetActive(false);
//            Hello.SetActive(true);
//            crying.SetActive(true);
//            HelloImage.SetActive(true);
//            Singing.SetActive(true);
//            Dancing.SetActive(true);      
//    }


//    public void Close()
//    {
//        Application.Quit();
//    }
//}


using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    public GameObject Button;
    public GameObject Singing;
    public GameObject Dancing;
    public GameObject WelcomeImage;
    public GameObject Hello;
    public GameObject Crying;
    public GameObject HelloImage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Use the factory to activate game objects when the Welcome method is called
    public void Welcome()
    {
        GameObjectFactory.DeactivateObjects(Button, WelcomeImage);
        GameObjectFactory.ActivateObjects(Hello, Crying, HelloImage, Singing, Dancing);
    }

    public void Close()
    {
        Application.Quit();
    }
}


    // Factory class to manage creation/activation of GameObjects
    public static class GameObjectFactory
    {
        public static GameObject CreateObject(string objectType, GameObject helloGreen, GameObject cryRed, GameObject singRed, GameObject danceRed)
        {
            switch (objectType)
            {
                case "Hello":
                    return helloGreen;
                case "Cry":
                    return cryRed;
                case "Sing":
                    return singRed;
                case "Dance":
                    return danceRed;
                default:
                    Debug.LogError("Invalid object type");
                    return null;
            }
        }

        public static void ActivateObjects(params GameObject[] gameObjects)
        {
            foreach (GameObject obj in gameObjects)
            {
                if (obj != null)
                {
                    obj.SetActive(true);
                }
            }
        }

        public static void DeactivateObjects(params GameObject[] gameObjects)
        {
            foreach (GameObject obj in gameObjects)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
        }
    }




