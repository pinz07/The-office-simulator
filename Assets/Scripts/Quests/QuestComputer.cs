using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestsComputer : MonoBehaviour
{
    /*This is a test for one quest logic */
    [Header("Quest Core")]
    [SerializeField] private QuestsMain QuestsM;
    [SerializeField] private bool RewardGet = false;
    [SerializeField] Antivirus AntivirusFunc;
    [SerializeField] private GameObject FoodOff;
    [SerializeField] private GameObject FoodOn;
    void Start()
    {

    }


    void Update()
    {
        if(AntivirusFunc.QuestComplete)
        {
            if(!RewardGet)
            {
                QuestsM.QuestComplete();
                RewardGet = true;
                FoodOff.active = true;
                FoodOn.active = false;
            }
        }
    }

}
