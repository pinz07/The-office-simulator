using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*Commentarii ya bydy pisat translitob ibo github ih lomaet esli oni na kirrilice.
  Script Questmain eto baza dlya vsey quest system.
Zdes vupolnyaetsya glavnya logica dlya raboti quests.
Ih otslehivanie i activacia scripts 4tobi zakonchit level or start ego. Sorry for my Russo-English :>
 */
public class QuestsMain : MonoBehaviour
{
    [Header("Core")]
    [SerializeField] private bool StartLevel = false;
    [SerializeField] private bool LevelComplete = false;
    [SerializeField] private int QuestsCount = 4;
    [SerializeField] private int CurrentQuestsComplete = 0;
    public bool LevelIsCompleteCopy;
    [SerializeField] private GameObject _LiftDoors;
    [SerializeField] private GameObject _TriggerScene;

    void Start()
    {
        if (!StartLevel)
            StartingLevel();
        _TriggerScene.SetActive(false);
    }


    void Update()
    {
        LevelIsCompleteCopy = LevelComplete;
        QuestsCompleteCheck();
    }

    private void StartingLevel()
    {
        /*Logic for start elevator*/
        StartLevel = false;
        Debug.Log("LevelStarted");
    }

    public void QuestComplete()
    {
        CurrentQuestsComplete++;
    }

    private void QuestsCompleteCheck()
    {
        if(!LevelComplete && CurrentQuestsComplete ==  QuestsCount)
        {
            LevelEnding();
            LevelComplete = true;

        }
 
    }

    private void LevelEnding()
    {
        /*Logic for openElevator*/
        Debug.Log("All quests complete. Lifts Door opened. Player can leave the level.");
        //BUILD//
        Destroy(_LiftDoors);
        _TriggerScene.SetActive(true);
        //BUILD//
    }
}
