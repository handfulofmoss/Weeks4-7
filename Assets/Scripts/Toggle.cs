using UnityEngine;

public class Toggle : MonoBehaviour
{

    public void ToggleMoon()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);

        //these do the same thing but the top one is way quicker for toggling something on an off

        ////if the game object is active turn it off: call SetActive and pass false
        //if (gameObject.activeInHierarchy == true)
        //{
        //    gameObject.SetActive(false);
        //}
        //else if (gameObject.activeInHierarchy == false)
        //{
        //    //otherwise the game object is inactive, so turn it on: call SetActive passing true
        //    gameObject.SetActive(true);
        //}

    }

}
