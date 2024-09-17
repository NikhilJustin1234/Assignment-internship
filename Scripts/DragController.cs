using UnityEngine;

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
            GameObject createdObject = GameObjectFactory.CreateObject("Hello", HelloGreen, CryRed, SingRed, DanceRed);
            if (createdObject != null)
            {
                createdObject.SetActive(true);
                Destroy(gameObject);
            }
        }
        else if (other.gameObject.CompareTag("CryButton"))
        {
            Invoke("GlowImage", 0.5f);
            GameObjectFactory.ActivateObjects(CryRed);
        }
        else if (other.gameObject.CompareTag("SingButton"))
        {
            Invoke("GlowImage", 0.5f);
            GameObjectFactory.ActivateObjects(SingRed);
        }
        else if (other.gameObject.CompareTag("DanceButton"))
        {
            Invoke("GlowImage", 0.5f);
            GameObjectFactory.ActivateObjects(DanceRed);
        }
    }

    // GlowImage will deactivate all game objects using the factory
    void GlowImage()
    {
        GameObjectFactory.DeactivateObjects(DanceRed, SingRed, CryRed, HelloGreen);
    }
}

