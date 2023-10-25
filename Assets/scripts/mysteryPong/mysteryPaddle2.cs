using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.UIElements;

public class mysteryPaddle2 : MonoBehaviour
{
    //var
    public float speed = 5f;
    //public float botYPosition = 0f;
    //public float botXPosition;
    public string leftOrRight;
    public float maxValue = 3.75f;
    public float maxXValue = 8.5f;
    public float minXValue = 0.35f;

    //public GameObject ball;
    public GameObject paddle1;
    public GameObject paddle2;

    //movement (and make sure paddle doesn't leave our world
    void paddleControl(KeyCode up,KeyCode down,KeyCode left,KeyCode right)
    {
        if (Input.GetKey(up) && transform.position.y < maxValue && mysteryCollision.mysteryCount < 18)
        {
            
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue && mysteryCollision.mysteryCount < 18)
        {
            
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(left) && transform.position.x > minXValue && mysteryCollision.mysteryCount > 11 && mysteryCollision.mysteryCount < 24)
        {

            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(right) && transform.position.x < maxXValue && mysteryCollision.mysteryCount > 11 && mysteryCollision.mysteryCount < 24)
        {

            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(down) && transform.position.y < maxValue && mysteryCollision.mysteryCount > 17)
        {

            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(up) && transform.position.y > -maxValue && mysteryCollision.mysteryCount > 17)
        {

            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(right) && transform.position.x > minXValue && mysteryCollision.mysteryCount > 23)
        {

            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(left) && transform.position.x < maxXValue && mysteryCollision.mysteryCount > 23)
        {

            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
     maxValue = 3.75f;
     maxXValue = 8.5f;
     minXValue = 0.35f;
}

    // Update is called once per frame
    void Update()
    {
        //diside if it should be left paddle or right paddle
        //left player
        if (leftOrRight == "left")
        {
            paddleControl(KeyCode.W, KeyCode.S, KeyCode.A, KeyCode.D);
        }
        //right player
        else if (leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow,KeyCode.LeftArrow,KeyCode.RightArrow);
        }
        
        
          if (mysteryCollision.mysteryCount > 5)
        {
            transform.localScale = new Vector3(0.7f, 0.7f ,0);
            maxValue = 4.65f;
        }

    }
    //void Botpaddle()
    //{
    //    transform.position = new Vector3(botXPosition, botYPosition, 0f);
    //    //transform.position = new Vector3(transform.position.x, ball.transform.position.y, 0f);
    //    if (ball.transform.position.y > paddle2.transform.position.y && transform.position.y < maxValue)
    //    {
    //        botYPosition += 3f * Time.deltaTime;
    //    } else if (ball.transform.position.y < paddle2.transform.position.y && transform.position.y > -maxValue)
    //    {
    //        botYPosition += -3f * Time.deltaTime;
    //    }
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{

    //    if (collision.gameObject.CompareTag("ball"))
    //    {
    //        mysteryCount += 1;
    //    }

    //}
}
