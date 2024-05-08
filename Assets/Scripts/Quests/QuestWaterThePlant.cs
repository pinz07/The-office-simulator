using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestsWaterThePlant : MonoBehaviour
{
    /*This is a test for one quest logic */
    [Header("Quest Core")]
    [SerializeField] private QuestsMain QuestsM;
    [SerializeField] private bool ThisQuestComplete = false;
    [SerializeField] private bool RewardGet = false;
    [SerializeField] private PlayerStat PS;
    [SerializeField] private int Score = 0;
    [SerializeField] private GameObject WaterCan;
    [SerializeField] private float Distance = 2f;
    [SerializeField] LayerMask interactLayer;
    [SerializeField] private int WaterAmountNeed = 2;
    [SerializeField] private int CurrentWaterCollect = 0;
    [SerializeField] private bool AllWaterCollected = false;

    void Start()
    {
        PS = GetComponentInParent<PlayerStat>();
        if (PS == null)
            Debug.LogError("PlayerStat not found");
    }


    void Update()
    {
        CollectTrash();
        if (Score > 2)
        {
            ThisQuestComplete = true;
            if(!RewardGet)
            {
                QuestsM.QuestComplete();
                RewardGet = true;
            }
            PS.PlayerDo = false;
            Destroy(gameObject);
        }
    }

    private void CollectTrash()
    {
        Camera mainCamera = Camera.main;
        if (mainCamera == null)
        {
            Debug.LogError("Main camera not found!");
            return;
        }
        RaycastHit hit;
        //Debug.DrawRay(transform.position, transform.forward * Distance, Color.red);
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, Distance, interactLayer))
        {
            if (hit.collider.CompareTag("TriggerWaterCan"))
            {
                Debug.Log("Press 'E' to interact");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(hit.collider.gameObject);
                    //Destroy(WaterCan);
                    Score++;
                    WaterCollectCheck();
                    //PlayerAudio.PickUpAudioPlay();
                }
            }
        }
    }
    private void WaterCollectCheck()
    {
        if (CurrentWaterCollect == WaterAmountNeed)
            AllWaterCollected = true;
    }


}
