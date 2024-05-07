using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestsTest : MonoBehaviour
{
    /*This is a test for one quest logic */
    [Header("Quest Core")]
    [SerializeField] private QuestsMain QuestsM;
    [SerializeField] private bool ThisQuestComplete = false;
    [SerializeField] private bool RewardGet = false;
    void Start()
    {
        
    }


    void Update()
    {
        GetRewardForQuest();
    }

    private void GetRewardForQuest()
    {
        if(ThisQuestComplete && !RewardGet)
        {
            QuestsM.CurrentQuestsComplete++;
            RewardGet = true;
        }
    }
}
