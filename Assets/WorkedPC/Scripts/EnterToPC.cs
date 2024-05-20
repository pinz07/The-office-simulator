using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterToPC : MonoBehaviour
{
    [SerializeField] private FirstPersonMovement PlayerMovement;
    [SerializeField] private bool PlayerInPC = false;
    [SerializeField] private GameObject Canvas;
    [SerializeField] private AudioSource OnSFX;
    [SerializeField] private bool PlayerCanUsePC = true;


    void Start()
    {

    }

    void Update()
    {
        Moving();
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("In PC trigger");
            if (Input.GetKeyUp(KeyCode.E) && PlayerCanUsePC)                
                PCStay(PlayerInPC);
        }
    }

    private void Moving()
    {
        if (PlayerInPC)
            PlayerMovement.CanMove = false;
        else PlayerMovement.CanMove = true;
    }

    public void PCStay(bool OnOff)
    {
        bool State = false;
        if (OnOff) State = false;
        if (!OnOff) State = true;

        PlayerInPC = State;
        Canvas.SetActive(State);
        Cursor.visible = State;
        OnSFX.Play();

        if(State)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

    }
}
