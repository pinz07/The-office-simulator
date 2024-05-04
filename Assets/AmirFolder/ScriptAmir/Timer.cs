using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public TextMeshPro clock;
    private int time = 6;

    private void Awake()
     {
      clock = gameObject.GetComponent<TextMeshPro>();
      InvokeRepeating("Time",1f,1f);
     }
     
    public void Time()
     {
      time -= 1;
      clock.text = time.ToString() + "" ;    
      if(time<= 0)
      {
        time += 1;
        Destroy(clock);
      }          
     }
}
