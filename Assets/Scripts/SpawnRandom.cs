using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnRandom : MonoBehaviour
{
    public GameObject duckPrefab;
    public GameObject spawnDuck;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos;

        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            newPos.x = Random.Range(-5, 5);
            newPos.y = Random.Range(-5, 5);
            transform.position = newPos;

            //spawns a prefab copy in the "newPos" position
            spawnDuck = Instantiate(duckPrefab, newPos, Quaternion.identity);
        }
    }
}
