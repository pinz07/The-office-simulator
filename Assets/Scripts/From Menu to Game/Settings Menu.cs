using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    
    public GameObject MainMenu;
    public GameObject Settings;

    public void SettingsOpening()
    {
        SceneManager.LoadScene(4);
    }

    public void SettingsClosing()
    {
        SceneManager.LoadScene(0);
        
    }
    
    
}
