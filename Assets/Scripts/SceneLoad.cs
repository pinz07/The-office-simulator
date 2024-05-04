using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public GameObject Screamer;

    private void OnTriggerEnter(Collider other)
    {
       if(this.CompareTag("Player") && other.CompareTag("Zone"))
       {
        InvokeRepeating("Scream",0f,1f);        
       }
    }
    
    public void Load()
    {
     SceneManager.LoadScene("Day2(Amir)");
         
    }

    public void Scream()
    {
     InvokeRepeating("Load",1f,1f);
     Screamer.active = true;  
    }
}
