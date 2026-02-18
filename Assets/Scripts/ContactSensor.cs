using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazrd;
    public bool isInHazard = false;
    public UnityEvent OnEnterSensor;
    public UnityEvent OnExitSensor;
    public UnityEvent<float> OnRandomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //set up makes it so it only sets to true or false once, instead of repeatedly doing so when in or out of sensors range
        if (hazrd.bounds.Contains(transform.position) == true)
        {
            if (isInHazard == true)
            {
                //still in hazard
            }
            else
            {
                //entered the hazard
                //do somthing
                Debug.Log("Entered the sensor!");
                OnEnterSensor.Invoke();
                isInHazard = true;
            }  
        }
        else
        {
            if (isInHazard == true)
            {
                //exiting the hazard
                //do somthing
                Debug.Log("Exited the sensor!");
                OnExitSensor.Invoke();
                OnRandomNumber.Invoke(Random.Range(0, 10));
                isInHazard = false;
            }
            else
            {
                //still outside the hazard

            }
        }
    }
    public void ShowNumber(float number)
    {
        Debug.Log(number);
    }
}
