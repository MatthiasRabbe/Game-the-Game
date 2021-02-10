using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScriptSceene : MonoBehaviour
{
    Scene scene = SceneManager.GetActiveScene();
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(scene.name == "Level 2")
        {
            SceneManager.LoadScene("The Crossing");
        }
        else
        {
            SceneManager.LoadScene("Level 2");
        }
        
        source.Play();
    }
}
