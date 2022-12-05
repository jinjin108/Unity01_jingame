using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float setTime = 300.0f;
    public Text countDownText;
    void Start()
    {
        countDownText.text = setTime.ToString();
    }

    void Update()
    {
        if(setTime > 0)
        {
            setTime -= Time.deltaTime;
            countDownText.text = Mathf.Round(setTime).ToString();

        }
        else
        {
            SceneManager.LoadScene("SceneB");
        }
    }
}
