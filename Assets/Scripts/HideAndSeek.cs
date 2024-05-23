using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HideAndSeek : MonoBehaviour
{
    [SerializeField] private GameObject _triggerHideAndSeek;
    [SerializeField] private GameObject _errorHideAndSeek;   
    void Start()
    {
     _errorHideAndSeek.active = false;          
    }

    private void OnTriggerEnter(Collider other)
    {
        //HS = HideAndSeek        
       if(this.CompareTag("Player") && other.CompareTag("HS"))
       {        
        _errorHideAndSeek.active = true;
        Screen.fullScreen = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        GetComponent<Jump>().enabled = false;
        GetComponent<Crouch>().enabled = false;
        GetComponentInChildren<FirstPersonMovement>().enabled = false;       
       }
    }

    public void StartHS()
    {
     SceneManager.LoadScene("HideAndSeek");
    }    
}
