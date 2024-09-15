using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
public class DragController : MonoBehaviour
{
    Vector3 mousePosition;
    public GameObject HelloGreen;
    public GameObject CryGreen;
    public GameObject HelloRed;
    public GameObject CryRed;
    public GameObject SingRed;
    public GameObject DanceRed;
    public GameObject CryImage;
    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();   
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HelloButton"))
        {
            
            HelloGreen.SetActive(true);
            Destroy(gameObject);



        }
        if (other.gameObject.CompareTag("CryButton"))
        {
            Invoke("GlowImage", .5f);
            CryRed.SetActive(true);
        }
        if (other.gameObject.CompareTag("SingButton"))
        {
            Invoke("GlowImage", .5f);
            SingRed.SetActive(true);
        }
        if (other.gameObject.CompareTag("DanceButton"))
        {
            Invoke("GlowImage", .5f);
            DanceRed.SetActive(true);
        }

       
    }

    void GlowImage()
    {
        DanceRed.SetActive(false);
        SingRed.SetActive(false);
        CryRed.SetActive(false);
        HelloGreen.SetActive(false);
    }

}
