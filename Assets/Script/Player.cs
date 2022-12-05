using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 5.0f ;
    public float mousespeed = 3.0f;
    float currentRot;
    public int arram;
    public Text t1;
    public GameObject die = null;
    public Camera fpsCam;

    Rigidbody rigid;

    float mouseX = 0;
    void Awake()
    {
        PlayerManager.instance = this;

        rigid = GetComponent<Rigidbody>();
        t1.text = ($"남은 알람갯수 : {arram}");
        currentRot = 0f;

    }

    void Update()
    {
        playerMove();
        mouseX += Input.GetAxis("Mouse X") * mousespeed;
        transform.eulerAngles = new Vector3(0, mouseX, 0);
    }

    void playerMove()
    {

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        transform.Translate(Vector3.forward * zSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * xSpeed * Time.deltaTime);
    }

    void RotCtrl()
    {
        float rotX = Input.GetAxis("Mouse Y") * mousespeed;
        float rotY = Input.GetAxis("Mouse X") * mousespeed;

        currentRot -= rotX;

        currentRot = Mathf.Clamp(currentRot, -80f, 80f);

        this.transform.localRotation *= Quaternion.Euler(0, rotY, 0);

        fpsCam.transform.localEulerAngles = new Vector3(currentRot, 0f, 0f);
    }



    private void OnCollisionEnter(Collision collision)
    {
        book bk = collision.gameObject.GetComponent<book>();
        if(bk)
        {
            bk.OpenBookUI();
        }
        Clock go = collision.gameObject.GetComponent<Clock>();
        if(go)
        {
            Vector3 gop = go.transform.position;
            go.OnClock();
            t1.text = ($"남은 알람갯수 : {arram}");
            if (arram <= 0)
            {
                SceneManager.LoadScene("Clear");
            }

            float x = gop.x + Random.Range(-15, 15);
            float z = gop.z + Random.Range(-15, 15);
            float y = gop.y + Random.Range(0 ,10);
            Object en = Resources.Load("Enemy");
            Instantiate(en, new Vector3(x, 0, z), Quaternion.identity);
        }
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if(enemy)
        {
            SceneManager.LoadScene("SceneB");
        }

    }

    private void OnCollisionExit(Collision collision)
    {


        book bk = collision.gameObject.GetComponent<book>();
        if (bk)
        {
            bk.CloseBookUI();
        }

    }
    
}
