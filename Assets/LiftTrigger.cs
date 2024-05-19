using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftTrigger : MonoBehaviour
{
    [SerializeField] private QuestsMain QuestM;
    [SerializeField] private LiftDoors LiftScript;
    void Start()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(!QuestM.LevelIsCompleteCopy)
            {
                LiftScript.DoorClose();
            }
            else if(QuestM.LevelIsCompleteCopy && !LiftScript.DoorState)
            {
                LiftScript.DoorOpens();
            }
        }
    }


    void Update()
    {
        
    }
}
