using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bb : MonoBehaviour
{

    void Start()
    {
        GameObject.Find("bb").transform.Find("ab").gameObject.SetActive(false);
    }

    void Update()
    {
       
    }
    void OnCollisionEnter(Collision collision)
    {
        Player pl = collision.gameObject.GetComponent<Player>();
        {
            GameObject.Find("bb").transform.Find("ab").gameObject.SetActive(true);
            Invoke("sam", 2.0f);
        }
    }

    void sam()
    {
        Destroy(gameObject);
    }
}
