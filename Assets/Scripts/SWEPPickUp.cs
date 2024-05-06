using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SWEPPickUp : MonoBehaviour
{
    [SerializeField] private float Distance = 2f;
    [SerializeField] LayerMask interactLayer;
    [SerializeField] private bool PlayerPickUpSWEP = false;
    [SerializeField] private PlayerAudioScript PlayerAudio;
    [SerializeField] private PlayerStat PS;

    private void Start()
    {
        PS = GetComponentInParent<PlayerStat>();
        if (PS == null)
            Debug.LogError("PlayerStat not found");
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Distance, interactLayer) && !PlayerPickUpSWEP)
        {
            if (hit.collider.CompareTag("SWEP"))
            {
                Debug.Log("Press 'E' to interact");
                if (Input.GetKeyDown(KeyCode.E) && !PS.PlayerDo)
                {
                    hit.collider.gameObject.GetComponent<PickAbleObject>().PickUpSWEP();
                    PlayerAudio.PickUpAudioPlay();
                    PS.PlayerDo = true;
                }
            }
        }
    }
}