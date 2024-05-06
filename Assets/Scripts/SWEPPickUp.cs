using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SWEPPickUp : MonoBehaviour
{
    [SerializeField] private float Distance = 2f;
    [SerializeField] LayerMask interactLayer;
    [SerializeField] private bool PlayerPickUpSWEP = false;
    [SerializeField] private PlayerAudioScript PlayerAudio;

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Distance, interactLayer) && !PlayerPickUpSWEP)
        {
            if (hit.collider.CompareTag("SWEP"))
            {
                Debug.Log("Press 'E' to interact");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<PickAbleObject>().PickUpSWEP();
                    PlayerAudio.PickUpAudioPlay();
                }
            }
        }
    }
}