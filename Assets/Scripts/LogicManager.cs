using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour
{
    public GameObject Playerbuter;
    public GameObject trig;
    public GameObject DecorativeSandwich;
    private int Score = 0;

    public GameObject PlayerWater;
    public GameObject trigWater;
    public GameObject DecorativeWater;
    private int ScoreWater = 0;

    private void Start()
    {
        Playerbuter.active = false;
        DecorativeSandwich.active = true;
        PlayerWater.active = false;
        DecorativeWater.active = true;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && Score >= 1)
        {
            Destroy(Playerbuter);
        }

        if (Input.GetKey(KeyCode.Q) && ScoreWater >= 1)
        {
            Destroy(PlayerWater);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Zone"))
        {
            DecorativeSandwich.active = false;
            Destroy(trig);
            Playerbuter.active = true;
            Score += 1;


        }

        if (this.CompareTag("Player") && other.CompareTag("HS"))
        {
            DecorativeWater.active = false;
            Destroy(trigWater);
            PlayerWater.active = true;
            ScoreWater += 1;


        }
    }
}