using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    
    public float moveSpeed = 3;
    

    [Header("Object Dispose")]
    Transform playerTransform;
    public float maxDistance = 50f;

    private void Start()
    {
        playerTransform = GameManager.instance.playerTransform;
    }
    private void Update()
    {
        float distance = Vector3.Distance(transform.position, playerTransform.position);

        if (distance > maxDistance)
        {
            Destroy(gameObject);
        }

        transform.position += new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
