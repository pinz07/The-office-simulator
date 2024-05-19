using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;

public class Antivirus : MonoBehaviour
{
    [SerializeField] private GameObject AntivirusPanel;
    [SerializeField] private Slider ProgressBar;
    [SerializeField] private EnterToPC CanUsePC;
    [SerializeField] private bool isComplete = false;
    [SerializeField] private TextMeshProUGUI TMPVirus;
    [SerializeField] private int Viruses = 0;
    private bool isCoroutineRunning = false;
    [SerializeField] public bool QuestComplete = false;
    [SerializeField] private GameObject ButtonStartVirus;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void AntivirusOpen()
    {
        AntivirusPanel.SetActive(true);
        Debug.Log("Антивирус открыт");
    }

    public void StartFindViruses()
    {
        StartCoroutine(VirusFindProgress());
        Destroy(ButtonStartVirus);
    }

    IEnumerator VirusFindProgress()
    {
        isCoroutineRunning = true;

        while (!isComplete)
        {

            float randomValue = Random.Range(0.05f, 0.09f);
            float targetValue = Mathf.Clamp01(ProgressBar.value + randomValue);

            ProgressBar.value = targetValue;

            if (ProgressBar.value >= 1f)
            {
                isComplete = true;
                Debug.Log("Сканирование завершено!");
                FindedViruses();
            }
            else
            {
                yield return new WaitForSeconds(2f);
            }
        }

        isCoroutineRunning = false;
    }

   private void FindedViruses()
    {
        int randomViruses = Random.Range(51, 123);
        Viruses = randomViruses;
        TMPVirus.SetText("Find  " + Viruses + " viruses files");
    }

    public void DeleteViruses()
    {
        if(isComplete)
        {
            TMPVirus.SetText("All viruses delete!");
            QuestComplete = true;
        }
    }

    public void CloseAntivirus()
    {
        AntivirusPanel.SetActive(false);
    }
}
