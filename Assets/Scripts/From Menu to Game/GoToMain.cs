using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMain : MonoBehaviour
{
    public Canvas canvas;

    public void GoMain()
    {
        SceneManager.LoadScene(0);
    }

    public void ContinueGame()
    {
        canvas.gameObject.SetActive(false);
    }

    
}
