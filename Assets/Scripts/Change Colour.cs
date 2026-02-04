using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    SpriteRenderer duck;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //assigns the duck renderer thing
       duck = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomColour()
    {
        duck.color = Random.ColorHSV();
    }
}
