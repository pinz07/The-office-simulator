using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour
{
    public GameObject text;
    public GameObject buter;
    public GameObject stol;
    public GameObject trig;
    public GameObject trig2;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            text.active = false;
            buter.active = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Zone"))
        {

            Destroy(trig);
        }

        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            buter.active = true;
            stol.active = false;
            Destroy(trig2);
        }
    }
}
