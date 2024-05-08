using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestsEatFood : MonoBehaviour
{
    /*This is a test for one quest logic */
    [Header("Quest Core")]
    [SerializeField] private QuestsMain QuestsM;
    [SerializeField] private bool ThisQuestComplete = false;
    [SerializeField] private bool RewardGet = false;
    [SerializeField] private PlayerStat PS;
    [Header("Quest")]
    [SerializeField] private GameObject Sandwich;
    [SerializeField] private GameObject Water;
    [SerializeField] bool SandwichEated = false;
    [SerializeField] bool WaterDrinked = false;
    [SerializeField] private AudioSource EatSFX;
    void Start()
    {
        PS = GetComponentInParent<PlayerStat>();
        if (PS == null)
            Debug.LogError("PlayerStat not found");
        EatSFX = GetComponent<AudioSource>();
    }


    void Update()
    {
        EatSandwich();
        DrinkWater();

        if(SandwichEated && WaterDrinked)
        {
            QuestsM.QuestComplete();
            PS.PlayerDo = false;
            Destroy(gameObject);
        }
    }

    private void EatSandwich()
    {
        if(Input.GetMouseButton(1))
        {
            Debug.Log("Am am am");
            EatSFX.Play();
            Destroy(Sandwich);
            SandwichEated =true;
        }
    }

    private void DrinkWater()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Glp glp glp");
            EatSFX.Play();
            Destroy(Water);
            WaterDrinked = true;
        }
    }
}
