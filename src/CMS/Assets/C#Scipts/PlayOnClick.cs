using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    public AudioSource MOOO;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            MOOO.Play();
        }
    }
}
