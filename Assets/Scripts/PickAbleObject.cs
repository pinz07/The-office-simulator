using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAbleObject : MonoBehaviour
{
    [SerializeField] private GameObject SWEPInPlayer;
 
    public void PickUpSWEP()
    {
        SWEPInPlayer.SetActive(true);
        Destroy(gameObject);
    }
}
