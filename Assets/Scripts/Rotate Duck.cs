using UnityEngine;
using UnityEngine.UI;

public class RotateDuck : MonoBehaviour
{
    public float currentValue = 0;
    public float maxRotation = 360;
    public Slider rotationSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationValue = transform.eulerAngles;
        currentValue = rotationValue.z;
        transform.eulerAngles = rotationValue;
        rotationSlider.value = currentValue;

    }
}
