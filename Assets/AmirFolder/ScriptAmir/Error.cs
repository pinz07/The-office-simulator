using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Error : MonoBehaviour
{
public GameObject error;
public GameObject triggerError;


public void Start()
{
    error.active = false;
    Screen.fullScreen = true;    
}
public void Could()
 {
  Cursor.lockState = CursorLockMode.Confined;
  Cursor.visible = false;      
  Destroy(triggerError);  
  Destroy(error);
  GetComponent<Player>().enabled = true;
  GetComponent<Camera>().enabled = true;
  GetComponentInChildren<aperator>().enabled = true;
 }
private void OnTriggerEnter(Collider other)
    {
       if(this.CompareTag("Error") && other.CompareTag("Player"))
       {        
        Screen.fullScreen = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;      
        error.active = true;
        GetComponent<Player>().enabled = false;
        GetComponent<Camera>().enabled = false;
        GetComponentInChildren<aperator>().enabled = false;                  
       }
    }
}


