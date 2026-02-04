using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class DescribeSprite : MonoBehaviour
{
    public TextMeshProUGUI description;
    public string objectDescription;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //find distance between gameobject and mouse position
        float distance = Vector2.Distance(transform.position, mousePos);

        //if the mouse is close enough && clicked: triggers true
        if (distance < 1 && Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            //sets the UI's text to the selected objects description
            description.text = objectDescription;
        }

    }
}
