using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour
{
    [SerializeField] private GameObject Playerbuter;
    [SerializeField] private GameObject trig;
    [SerializeField] private GameObject DecorativeSandwich;
    [SerializeField] private int Score = 0;

    [SerializeField] private GameObject PlayerWater;
    [SerializeField] private GameObject trigWater;
    [SerializeField] private GameObject DecorativeWater;
    [SerializeField] private int ScoreWater = 0;

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