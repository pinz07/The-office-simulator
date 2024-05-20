using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftTrigger : MonoBehaviour
{
    [SerializeField] private QuestsMain QuestM;
    [SerializeField] private LiftDoors LiftScript;
    [SerializeField] private bool StateLift = false;
    void Start()
    {

    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LiftScript.DoorClose();
            StateLift = true;
        }
    }


    void Update()
    {
     if(StateLift = false)
        {
            LiftScript.DoorOpens();
        }
    }
}
