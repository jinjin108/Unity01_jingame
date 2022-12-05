using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonzen : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Light").transform.Find("son").gameObject.SetActive(false);

        onoff();
    }

    private void Update()
    {
        onoff();
    }
    void onoff()
    {
        if (Input.GetKey(KeyCode.R))
        {
            GameObject.Find("Light").transform.Find("son").gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.E))
        {
            GameObject.Find("Light").transform.Find("son").gameObject.SetActive(true);
        }
    }
}
