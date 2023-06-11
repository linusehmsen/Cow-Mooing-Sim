using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    public AudioSource MOOO;


    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            MOOO.Play();
        }
    }
}
