using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform targetPos;
    float force = 1;

    Rigidbody2D rb;
    Vector3 t;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D;
    }

    // Update is called once per frame
    void Update()
    {        
        if(Time.timeSinceLevelLoad > 3 )
        {
           
            //transform.position = Vector3.Lerp(transform.position, targetPos.position, 0.01f);
            Vector3 f = targetPos.position - transform.position;
            f = f.normalized;
            f = f * force;
            gameObject.GetComponent<Rigidbody2D>().AddForce(f);
            
            if (rb.velocity.magnitude > 0.001f)
            {
                
            }

            //Debug.Log(rb.velocity.magnitude);
        }



    }
}
