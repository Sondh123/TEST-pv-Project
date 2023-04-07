using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public int hp = 5;
    Score score;
    private Rigidbody2D rb;
    public bool areMoving;
    Vector3 vector;
    EnemyManager enemyManager;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
        enemyManager = FindObjectOfType<EnemyManager>();
        rb = gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D;
        areMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        vector = transform.position;
        if (hp < 1)
        {
            score.score += 1;
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "bullet")
        {           
            hp -= 1;
        }
    }
}
