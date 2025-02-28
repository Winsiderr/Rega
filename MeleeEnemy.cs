using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{
    public int kd;
    public bool isNotKd = true;
    public bool contact = false;
    public float speed;
    public Transform target;
    void Start()
    {
        target = Hero.singleton.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if(isNotKd && contact)
        {
            StartCoroutine(Hit());
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("касание");
        if(collision.gameObject.GetComponent<Hero>())
        {
            contact = true;
        }
    }
    IEnumerator Hit()
    {
        Hero.singleton.gameObject.GetComponent<Hero>().TakeDamage(damage);
        isNotKd = false;
        yield return new WaitForSeconds(kd);
        isNotKd = true;
        contact = false;
    }

}
