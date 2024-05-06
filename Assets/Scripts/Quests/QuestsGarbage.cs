using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestsGarbage : MonoBehaviour
{
    [Header("Quest Core")]
    [SerializeField] private QuestsMain QuestsM;
    [SerializeField] private bool ThisQuestComplete = false;
    [SerializeField] private bool RewardGet = false;
    [Header("GarbageQuest")]
    [SerializeField] private int GarbageAmountNeed = 2;
    [SerializeField] private int CurrentGarbageCollect = 0;
    [SerializeField] private bool AllGarbageCollected = false;
    [SerializeField] private float Distance = 2f;
    [SerializeField] LayerMask interactLayer;
    [SerializeField] GameObject GarbageChute;

    void Update()
    {
        if (!AllGarbageCollected)
            CollectTrash();
        if(AllGarbageCollected)
            CleanGarbage();

    }

    private void GetRewardForQuest()
    {
        if (ThisQuestComplete && !RewardGet)
        {
            QuestsM.CurrentQuestsComplete++;
            RewardGet = true;
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
            if (hit.collider.CompareTag("Garbage"))
            {
                Debug.Log("Press 'E' to interact");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(hit.collider.gameObject);
                    CurrentGarbageCollect++;
                    GargabeCollectCheck();
                    //PlayerAudio.PickUpAudioPlay();
                }
            }
        }
    }

    private void GargabeCollectCheck()
    {
        if (CurrentGarbageCollect == GarbageAmountNeed)
            AllGarbageCollected = true;
    }

    private void CleanGarbage()
    {
        RaycastHit hit;
        Camera mainCamera = Camera.main;
        if (mainCamera == null)
        {
            Debug.LogError("Main camera not found!");
            return;
        }
        Debug.DrawRay(mainCamera.transform.position, mainCamera.transform.forward * Distance, Color.red);
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, Distance, interactLayer))
        {
            if (hit.collider.gameObject == GarbageChute)
            {
                Debug.Log("Press 'E' to interact with Garbage Chute");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ThisQuestComplete = true;
                    GetRewardForQuest();
                    Destroy(gameObject);
                }
            }
        }
    }
}
