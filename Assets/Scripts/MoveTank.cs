using UnityEngine;

public class MoveTank : MonoBehaviour
{
    public float speed = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.RightArrow)== true)
        {
            Vector3 newPos = transform.position;
            newPos.x += speed;
            newPos = transform.position;
        }
    }
}
