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
    [SerializeField] private AudioSource DrinkSFX;
    [SerializeField] private GameObject FoodOff;
    [SerializeField] private GameObject FoodOn;
    [SerializeField] private GameObject TextF;
    [SerializeField] private GameObject TextB;
    void Start()
    {
        PS = GetComponentInParent<PlayerStat>();
        if (PS == null)
            Debug.LogError("PlayerStat not found");
        TextF.SetActive(true);
        TextB.SetActive(true);
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
            FoodOff.active = true;
            FoodOn.active = false;
            TextF.SetActive(false);
        }
    }

    private void DrinkWater()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Glp glp glp");
            DrinkSFX.Play();
            Destroy(Water);
            WaterDrinked = true;
            TextB.SetActive(false);
        }
    }
}
