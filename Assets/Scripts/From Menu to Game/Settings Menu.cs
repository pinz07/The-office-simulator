using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Settings;

    public void SettingsOpening()
    {
        MainMenu.SetActive(false);
        Settings.SetActive(true);
    }

    public void SettingsClosing()
    {
        Settings.SetActive(false);
        MainMenu.SetActive(true);
    }

    
}
