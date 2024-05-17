using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOpened : MonoBehaviour
{
    private GoToMain _Xcanvas;

    private void Start()
    {
        _Xcanvas = GetComponent<GoToMain>();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _Xcanvas.canvas.gameObject.SetActive(true);
        }
    }
}
