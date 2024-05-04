using UnityEngine;
using TMPro;
public class Door : MonoBehaviour
{
    public TextMeshPro clock;
    private int time = 15;

    private void Awake()
    {
        clock = gameObject.GetComponent<TextMeshPro>();
        InvokeRepeating("Timer", 1f, 1f);
    }

    public void Timer()
    {
        time -= 1;
        clock.text = time.ToString() + "";
        if (time <= 0)
        {
            time += 1;
        }
    }
}
