using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.ParticleSystem;

public class Sckreamer : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        enemy.active = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enemy.active = true;
            player.GetComponentInChildren<Crouch>().enabled = false;
            player.GetComponentInChildren<Jump>().enabled = false;
            player.GetComponentInChildren<FirstPersonMovement>().enabled = false;
            InvokeRepeating("SceneEnd", 1, 1);

        }
    } 

    public void SceneEnd()
    {
        SceneManager.LoadScene(5);
    }
}
