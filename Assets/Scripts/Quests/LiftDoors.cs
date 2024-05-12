using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LiftDoors : MonoBehaviour
{
    [SerializeField] private Transform LeftDoor;
    [SerializeField] private Transform LeftDoorToPosOpen;
    [SerializeField] private Transform LeftDoorToPosClose;
    [SerializeField] private Transform RightDoor;
    [SerializeField] private Transform RightDoorToPosOpen;
    [SerializeField] private Transform RightDoorToPosClose;
    [SerializeField] private float defaultTime = 5f;

    [SerializeField] private bool DoorState = false;
    void Start()
    {
        DoorOpens();
    }

    private void DoorOpens()
    {
        LeftDoor.DOMove(LeftDoorToPosOpen.position, defaultTime);
        RightDoor.DOMove(RightDoorToPosOpen.position, defaultTime);
        DoorState = true;

    }

    private void DoorClose()
    {
        LeftDoor.DOMove(LeftDoorToPosClose.position, defaultTime);
        RightDoor.DOMove(RightDoorToPosClose.position, defaultTime);
        DoorState = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.H))
        {
            DoorClose();
        }
    }
}
