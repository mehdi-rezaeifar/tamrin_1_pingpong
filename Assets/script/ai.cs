using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour
{
    float speed = 30;
    public GameObject ball_1;
    public GameObject ball_2;
    float ball_y  = 0;
    float ball_x  = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       float ball_1_y  = ball_1.transform.position.y;
       float ball_1_x  = ball_1.transform.position.x;
       float ball_2_y  = ball_2.transform.position.y;
       float ball_2_x  = ball_2.transform.position.x;
       
       float rocket_y = transform.position.y;
       float rocket_x = transform.position.x;
       float rocket_h = GetComponent<BoxCollider2D>().transform.localScale.y;
       float direction;

       if (rocket_x - ball_1_x > rocket_x - ball_2_x)
       {
           ball_x = ball_2_x;
           ball_y = ball_2_y;
       }

       else 
       {
           ball_x = ball_1_x;
           ball_y = ball_1_y;
       }
       if(ball_x > 0  )
       {
            if(ball_y + rocket_h < rocket_y)
            {
                    direction=-1;
            }
            else if(ball_y - rocket_h > rocket_y)
            {
                    direction= +1;
            }
                else 
                {
                    direction= 0;
                }
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, direction) * speed;
            
       }
     }
      
}
