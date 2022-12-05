using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dievideo : MonoBehaviour
{
    public RawImage dieimg;
    public Image gameover;
    public Image restart;
    void Start()
    {
        StartCoroutine("FadeIn");
        StartCoroutine("FadeIn2");
        StartCoroutine("FadeOut");
    }

    private void Update()
    {
    }
    IEnumerator FadeOut()
    {
        while (dieimg.color.a >= 0)
        {
            float alpha = dieimg.color.a - 0.0001f;
            dieimg.color = new Color(dieimg.color.r, dieimg.color.g, dieimg.color.b, alpha);
            yield return null;
        }

    }
    IEnumerator FadeIn()
    {
        while (gameover.color.a >= 0)
        {
            float alpha = gameover.color.a + 0.0007f;
            gameover.color = new Color(gameover.color.r, gameover.color.g, gameover.color.b, alpha);
            yield return null;
        }

    }
    IEnumerator FadeIn2()
    {
        while (restart.color.a >= 0)
        {
            float alpha = restart.color.a + 0.0005f;
            restart.color = new Color(restart.color.r, restart.color.g, restart.color.b, alpha);
            yield return null;
        }

    }

    public void ReTitle()
    {
        SceneManager.LoadScene("GameStage");
    }

}

