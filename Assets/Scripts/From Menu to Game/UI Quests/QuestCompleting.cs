using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestCompleting : MonoBehaviour
{
    public GameObject flower;
    public GameObject ateOmlet;
    public GameObject work;
    public GameObject musor;
    public GameObject left;

    public bool Xflower = false;
    public bool Xomlet = false;
    public bool Xwork = false;
    public bool Xmusor = false;
    public bool Xleft = false;

    public void Update()
    {
        if (Xflower == true)
        {
            flower.SetActive(false);
        }

        if (Xomlet == true)
        {
            ateOmlet.SetActive(false);
        }

        if (Xwork == true)
        {
            work.SetActive(false);
        }

        if (Xmusor == true)
        {
            musor.SetActive(false);
        }

        if (Xleft == true)
        {
            left.SetActive(false);
        }


        if (Xflower == false)
        {
            flower.SetActive(true);
        }

        if (Xomlet == false)
        {
            ateOmlet.SetActive(true);
        }

        if (Xwork == false)
        {
            work.SetActive(true);
        }

        if (Xmusor == false)
        {
            musor.SetActive(true);
        }

        if (Xleft == false)
        {
            left.SetActive(true);
        }
    }

}
