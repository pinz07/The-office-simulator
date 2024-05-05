using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Error : MonoBehaviour
{
public GameObject error;
public GameObject triggerError;


public void Start()
{
    error.active = true;
    Screen.fullScreen = true;    
}
public void Could()
 {
  Cursor.lockState = CursorLockMode.Confined;
  Cursor.visible = true;      
  Destroy(triggerError);  
  Destroy(error);
  GetComponent<Player>().enabled = true;
  GetComponent<Camera>().enabled = true;
  GetComponentInChildren<LogicManager>().enabled = true;
 }
private void OnTriggerEnter(Collider other)
    {
       if(this.CompareTag("Player") && other.CompareTag("Error"))
       {        
        Screen.fullScreen = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;      
        error.active = true;
        GetComponent<Player>().enabled = false;
        GetComponent<Camera>().enabled = false;
        GetComponentInChildren<LogicManager>().enabled = false;                  
       }
    }
}

