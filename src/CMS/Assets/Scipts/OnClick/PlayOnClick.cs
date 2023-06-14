using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    public AudioSource MOOO;
    public Canvas pauseMenu;


    
    void Update()
    {
        if(pauseMenu.enabled == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                MOOO.Play();
            }
        }
    }
}
