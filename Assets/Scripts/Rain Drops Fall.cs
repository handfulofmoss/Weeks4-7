using UnityEngine;

public class RainDropsFall : MonoBehaviour
{
    //variables for raindrop transform
    float speed = -0.06f;
    public Vector2 rainPos;
    public float maxPos = -5;
    public bool hitGround = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //makes the raindrop copys from list fall down off screen
        if (rainPos.y >= maxPos)
        {
            rainPos = transform.position;
            rainPos.y += speed;
            transform.position = rainPos;
        }
    }
}
