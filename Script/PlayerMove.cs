using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed = 150f; // tốc độ di chuyển trên bàn phím

    private Rigidbody2D rb;
    Transform player;
    public float mapWidth = 4.0f;
    public float mapLength = 10.0f;
    // giới hạn chiều ngang, doc di chuyển của player tránh nó chạy ra khỏi màn hình

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameManager.instance.playerTransform;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // di chuyen
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed;


        Vector2 newPosition = rb.position + Vector2.right * x + Vector2.up * y;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        newPosition.y = Mathf.Clamp(newPosition.y, -mapLength, mapLength);
        rb.MovePosition(newPosition);

    }

    public void EndGame()
    {
        
    }


}