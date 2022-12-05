using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book : MonoBehaviour
{
   public GameObject BookUI = null;

    public  void OpenBookUI()
    {
        if (BookUI == null)
        {
            Object book = Resources.Load("BookUI");
            BookUI = (GameObject)Instantiate(book);
        }
        BookUI.SetActive(true);
    }

    public  void CloseBookUI()
    {
        if (BookUI != null)
        {
            BookUI.SetActive(false);
        }

    }
}
