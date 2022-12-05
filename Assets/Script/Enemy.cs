using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform Target;
    NavMeshAgent nav;
    Rigidbody rigid;
    public GameObject die = null;
    void Awake()
    {
        Target = PlayerManager.instance.transform;
        nav = GetComponent<NavMeshAgent>();
        rigid = GetComponent<Rigidbody>();
        EnemyManager.enemy = this;
        Invoke("TimeOver", 40);
    }

    void Update()
    {
        nav.SetDestination(Target.position);
    }
    private void FixedUpdate()
    {
        Freeze();
    }
    public  void Die()
    {
        if (die == null)
        {
            Object diee = Resources.Load("die");
            die = (GameObject)Instantiate(diee);
        }
    }
    void Freeze()
    {
        rigid.velocity = Vector3.zero;
        rigid.angularVelocity = Vector3.zero;
    }

    void TimeOver()
    {
        Destroy(gameObject);
    }
}
