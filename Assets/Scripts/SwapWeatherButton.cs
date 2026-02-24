using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SwapWeatherButton : MonoBehaviour
{
    //variables for character sprite
    public SpriteRenderer guy;
    public List<Sprite> guySprites;
    //boolean to check current selected weather
    public bool isSunny = true;

    //variables for rain drop prefab and list
    public GameObject rainClouds;
    public GameObject rainPrefab;
    public GameObject spawnedRain;
    public List<GameObject> rainDrops;
    public float rainDropTimer = 0f;
    float maxRainDrops = 10;

    public Transform ground;
    public RainDropsFall rainScript;

    //audio source variables
    public AudioSource audioSource;
    public AudioClip rainAtmosphere;
    public AudioClip outsideAtmosphere;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //plays background sound effects on startup
        audioSource.clip = outsideAtmosphere;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 randomPos;
        //when its raining, cloud will appewar and raindrops will fall
        if (isSunny == false)
        {
            rainDropTimer += Time.deltaTime;
            //spawns a new raindrop every .2 seconds and caps at 10 raindrops on screen at a time
            if (rainDropTimer > 0.2 && rainDrops.Count <= maxRainDrops)
            {
                //sets a random starting position for each raindrop
                randomPos.x = Random.Range(-10, 10);
                randomPos.y = Random.Range(7, 5);

                //spawns a copy of the raindrop prefab
                spawnedRain = Instantiate(rainPrefab, randomPos, Quaternion.identity);
                rainScript = spawnedRain.GetComponent<RainDropsFall>();
                rainDrops.Add(spawnedRain);
                rainDropTimer = 0;
            }
            //loops through the raindrop list
            for (int i = rainDrops.Count - 1; i >= 0; i--)
            {
                //checks if the raindrops position is off screen and then destroys them if true
                if (rainDrops[i].transform.position.y <= ground.position.y)
                {
                    Destroy(rainDrops[i]);
                    rainDrops.Remove(rainDrops[i]);
                }
            }
        }
        //resets the raindrop spawn timer for whenever max raindrops are on screen or weather is set to sunny
        else if (rainDrops.Count >= maxRainDrops)
        {
            rainDropTimer = 0;
        }
        else
        {
            rainDropTimer = 0;
        }
    }

    //function for button to use too swap between weathers
    public void CheckWeather()
    {
        //when button is pressed and weather is currently sunny, it will swap to rainy, swap the character sprite,
        //and play according background sound effect
        if (isSunny == true)
        {
            guy.sprite = guySprites[1];
            rainClouds.SetActive(true);
            audioSource.clip = rainAtmosphere;
            audioSource.Play();
            isSunny = false;
        }
        //when button is pressed and weather is currently rainy, it will swap to sunny, swap the character sprite,
        //and play according background sound effect
        else if (isSunny == false)
        {
            guy.sprite = guySprites[0];
            rainClouds.SetActive(false);
            audioSource.clip = outsideAtmosphere;
            audioSource.Play();
            isSunny = true;
        }
    }
}
