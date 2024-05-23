using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioScript : MonoBehaviour
{

    [SerializeField] private AudioSource PickUpSFX;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PickUpAudioPlay()
    {
        PickUpSFX.Play();
    }
}
