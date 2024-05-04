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
  GetComponent<Jump>().enabled = true;
  GetComponent<Crouch>().enabled = true;
  GetComponentInChildren<FirstPersonMovement>().enabled = true;
 }
private void OnTriggerEnter(Collider other)
    {
       if(this.CompareTag("Player") && other.CompareTag("Error"))
       {        
        Screen.fullScreen = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;      
        error.active = true;
        GetComponent<Jump>().enabled = false;
        GetComponent<Crouch>().enabled = false;
        GetComponentInChildren<FirstPersonMovement>().enabled = false; 
       }
    }
}


