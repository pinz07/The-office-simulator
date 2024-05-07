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
    public int CurrentQuestsComplete = 0;

    void Start()
    {
        if (!StartLevel)
            StartingLevel();
    }


    void Update()
    {
        QuestsCompleteCheck();
    }

    private void StartingLevel()
    {
        /*Logic for start elevator*/
        StartLevel = false;
        Debug.Log("LevelStarted");
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
        SceneManager.LoadScene(0);
        //BUILD//
    }
}
