using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    
    void Start()
    {
        gameObject.SetActive(false);
        Invoke("on", 11.0f);

    }

    void on()
    {
        gameObject.SetActive(true);
    }

    public void ReTitle()
    {
        SceneManager.LoadScene("GameStage");
    }

}
