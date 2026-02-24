using UnityEngine;
using UnityEngine.UI;

public class RotateSunandMoon : MonoBehaviour
{
    //variable for slider
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //when the slider is adjusted, the sun and moon will rotate so the according sprite is visable
    //and matches the sky
    public void Rotate()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z = slider.value / 255f * 180f;
        transform.eulerAngles = newRotation;
    }
}
