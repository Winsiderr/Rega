using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    // Start is called before the first frame update
    private int speed = 5;
    private Rigidbody2D rb;
    private int hp = 10;
    public static Hero singleton { get; private set; }
    public GameObject die;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Hit();
    }
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        rb.velocity = new Vector2(Input.GetAxis("Vertical") * speed, rb.velocity.y);
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.x);
    }
    void Hit()
    {
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    nowsword.GetComponent<Swords>().kik();
        //}
    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            die.SetActive(true);
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }

}
