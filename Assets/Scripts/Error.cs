using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Error : MonoBehaviour
{
    [SerializeField] private GameObject error;
    [SerializeField] private GameObject triggerError;
    [SerializeField] private AudioSource AudioError;


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
        GetComponentInChildren<FirstPersonLook>().enabled = true;
        GetComponentInChildren<FirstPersonMovement>().enabled = true;
        GetComponentInChildren<Jump>().enabled = true;
        GetComponentInChildren<Crouch>().enabled = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Error"))
        {
            Screen.fullScreen = false;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            error.active = true;
            GetComponentInChildren<Crouch>().enabled = false;
            GetComponentInChildren<Jump>().enabled = false;
            GetComponentInChildren<FirstPersonMovement>().enabled = false;
            GetComponentInChildren<FirstPersonLook>().enabled = false;
            AudioError.Play();
 

        }
    }
    public void ErrorAud()
    {
        AudioError.Play();
    }
}


