using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSource : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
        Invoke("BgmOn", 2.0f);

    }

    void Update()
    {
        
    }

    void BgmOn()
    {
        gameObject.SetActive(true);
    }
}
