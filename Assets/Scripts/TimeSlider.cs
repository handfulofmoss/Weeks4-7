using UnityEngine;
using UnityEngine.UI;

public class TimeSlider : MonoBehaviour
{
    //variables for slider and sky
    public SpriteRenderer sr;
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //assigns the sky sprite to the spriteRenderer
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //when slider is adjusted, the skys transparency will change to make it appear as night or day depending
    public void ChangeTransparency()
    {
        sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, slider.value / 255f);
    }
}
