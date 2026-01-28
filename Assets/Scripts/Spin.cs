using UnityEngine;

public class SpinObject : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //creats a variable for the rotation, updates it based on the speed, then applies the rotation to the object(s)
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = newRotation;
    }


    public void StartSpin()
    {
        speed = 100;
    }

    public void StopSpin()
    {
        speed = 0;
    }
}
