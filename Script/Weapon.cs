using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject projectile;

    public float fireDelta = 0.01F;
    public int fireBallDmg = 1;

    private float nextFire;
    private float myTime = 0.01F;

    PlayerMove playerMove;

 

    private void Start()
    {
        playerMove = GetComponentInChildren<PlayerMove>();
        
    }
    private void Update()
    {
        myTime += Time.deltaTime;
        if (Input.GetKey("space") && myTime > fireDelta)
        {                        
            SpawnBullet();                        
            myTime = 0;
        }


    }

    private void SpawnBullet()
    {
        GameObject Fire = Instantiate(projectile);

        Vector3 newFireBallPosition = transform.position;
        Fire.transform.position = newFireBallPosition;       
    }
}
