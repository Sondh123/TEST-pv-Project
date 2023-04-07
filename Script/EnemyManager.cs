using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] List<Transform> enemiesPos0;
    [SerializeField] List<Transform> enemiesPos1;
    [SerializeField] List<Transform> enemiesPos2;
    [SerializeField] List<Transform> enemiesPos3;

    
    private float time;
    public bool isMoving;
    void Start()
    {
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {        
        time = Time.timeSinceLevelLoad;

        if (time > 4.0f && time < 8.0f)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i] == null)
                {
                    continue;
                }
                enemies[i].transform.position = Vector3.Lerp(enemies[i].transform.position, enemiesPos0[i].position, 0.05f);              

            }
        }
        if(time > 10.0f && time < 15.0f)
        {
            for (int i = 0; i < enemies.Length; i++)
            {   
                if(enemies[i] == null)
                {
                    continue;
                }
                 enemies[i].transform.position = Vector3.Lerp(enemies[i].transform.position, enemiesPos1[i].position, 0.005f);
   
            }
        }
        if (time > 15.0f && time < 20.0f)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i] == null)
                {
                    continue;
                }
                
                enemies[i].transform.position = Vector3.Lerp(enemies[i].transform.position, enemiesPos2[i].position, 0.005f);
            }
        }

        if (time > 20f)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i] == null)
                {
                    continue;
                }
                enemies[i].transform.position = Vector3.Lerp(enemies[i].transform.position, enemiesPos3[i].position, 0.005f);

            }
        }

    }

    public void CheckMoving()
    {

    }
}
