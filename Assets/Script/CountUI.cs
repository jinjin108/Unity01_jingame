using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountUI : MonoBehaviour
{
    public Text t1;
    Text t2;
    void Start()
    {
        txt();
    }

    void txt()
    {
        t1.text = ($"���� �˶����� : {PlayerManager.instance.arram}");
    }
}
