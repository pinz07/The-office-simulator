using UnityEngine;
using DG.Tweening;
using TMPro;

public class LiftDoors : MonoBehaviour
{
    [SerializeField] private Transform LeftDoor;
    [SerializeField] private Transform LeftDoorToPosOpen;
    [SerializeField] private Transform LeftDoorToPosClose;
    [SerializeField] private Transform RightDoor;
    [SerializeField] private Transform RightDoorToPosOpen;
    [SerializeField] private Transform RightDoorToPosClose;
    [SerializeField] private float defaultTime = 5f;
    [SerializeField] private TextMeshPro clock;
    [SerializeField] private int time = 20;
    

    [SerializeField] public bool DoorState = false;
    void Start()
    {
        InvokeRepeating("Time", 1f, 1f);
        
    }
    public void Time()
    {  
        clock.text = time.ToString() + "";
        if (time <= 0)
        {
            time += 1;
            DoorOpens();  
            InvokeRepeating("DoorClose", 10f, 10f);
        }
        time -= 1;
    }

    public void DoorOpens()
    {
        LeftDoor.DOMove(LeftDoorToPosOpen.position, defaultTime);
        RightDoor.DOMove(RightDoorToPosOpen.position, defaultTime);
        DoorState = true;

    }

    public void DoorClose()
    {
        LeftDoor.DOMove(LeftDoorToPosClose.position, defaultTime);
        RightDoor.DOMove(RightDoorToPosClose.position, defaultTime);
        DoorState = false;
    }
    // Update is called once per frame
    void Update()
    {
    
    }
}
