using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    GameObject go;
    public  GameObject alarmclock = null;
    public  void OnClock()
    {
        PlayerManager.instance.arram -= 1;
        if (alarmclock == null)
        {
            Object clock = Resources.Load("alarm clock");
            alarmclock = (GameObject)Instantiate(clock);
        }
        Destroy(gameObject);
    }
}
