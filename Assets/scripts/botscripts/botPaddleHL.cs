using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class botPaddleHL : MonoBehaviour
{
    //var
    public float speed = 5f;
    public float botYPosition = 0f;
    public float botXPosition;
    public string leftOrRight;
    public float maxValue = 3.75f;
    public GameObject ball;
    public GameObject paddle1;
    public GameObject paddle2;

    //movement (and make sure paddle doesn't leave our world
    void paddleControl(KeyCode up,KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y < maxValue)
        {
            
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue)
        {
            
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //diside if it should be left paddle or right paddle
        //left player
        if (leftOrRight == "left")
        {
            paddleControl(KeyCode.W, KeyCode.S);
        }
        //right player
        else if (leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
        //bot
        else if (leftOrRight == "bot")
        {

            Botpaddle();

        }
           
    }
    //bot
    void Botpaddle()
    {
        transform.position = new Vector3(botXPosition, botYPosition, 0f);
        //transform.position = new Vector3(transform.position.x, ball.transform.position.y, 0f);
        //bot up
        if (ball.transform.position.y > paddle2.transform.position.y && transform.position.y < maxValue)
        {
            botYPosition += 4f * Time.deltaTime;
        } 
        //bot down
        else if (ball.transform.position.y < paddle2.transform.position.y && transform.position.y > -maxValue)
        {
            botYPosition += -4f * Time.deltaTime;
        }
    }
}
