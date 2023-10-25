using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class mysteryCollision : MonoBehaviour
{
    //var 

    //direction and speed
    public float xPosition = 0f;
    public float yPosition = 0f;

    public float xSpeed = 4f;
    public float ySpeed = 4f;

    //random direction
    public int UOrD = 0;
    public int lOrR = 0;

    //text
    private GameObject scoreGameObject;
    private TMPro.TMP_Text scoreboard;
    private int player1Score;
    private int player2Score;
    private int winScore = 3;

    //ball increase speed
    public float ballSpeedIncreaseX = 1.05f;
    public float ballSpeedIncreaseY = 1.02f;

    //mystery pong
    static public int mysteryCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //text
        scoreGameObject = GameObject.Find("score");
        scoreboard = scoreGameObject.GetComponent<TMPro.TMP_Text>();

        //postion and random direction
        transform.position = new Vector3(xPosition, yPosition, 0f);
        var UOrD = Random.Range(0, 2);
        if (UOrD == 0)
        {
            ySpeed = ySpeed * -1f;
        }
        var lOrR = Random.Range(0, 2);
        if (lOrR == 0)
        {
            xSpeed = xSpeed * -1f;
        }

        mysteryCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //speed
        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;

        //makes sure the var are = too x and y position in game world
        transform.position = new Vector3(xPosition, yPosition, 0f);

        //if someone scores 3 times they win
        if(player1Score >= winScore)
        {
            SceneManager.LoadScene("winScreenMLeft");
        } 
        if(player2Score >= winScore)
        {
            SceneManager.LoadScene("winScreenMRight");
        }

        //you can stop by pressing esc
        if (Input.GetKey(KeyCode.Escape))
        {

            SceneManager.LoadScene("menu");
        }


        if (mysteryCount > 5)
        {
            transform.localScale = new Vector3(0.3f, 2.5f, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //walls
        if (collision.gameObject.CompareTag("horizontal"))
        {
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("vertical1"))
        {
            //reset position
            xPosition = 0f;
            yPosition = 0f;

            //reset speed and ball goes to winner
            xSpeed = 4f;
            ySpeed = 4f;

            //up or down is random
            var UOrD = Random.Range(0, 2);
            if (UOrD == 0)
            {
                ySpeed = ySpeed * -1f;
            }

            //score
            player2Score++;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (collision.gameObject.CompareTag("vertical2"))
        {
            //reset position
            xPosition = 0f;
            yPosition = 0f;

            //reset speed and ball goes to winner
            xSpeed = -4f;
            ySpeed = -4f;

            //up or down is random
            var lOrR = Random.Range(0, 2);
            if (lOrR == 0)
            {
                ySpeed = ySpeed * -1f;
            }

            //score
            player1Score++;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


        //if paddle is hit: send ball other way and speed it up a bit and mystery counter
        if (collision.gameObject.CompareTag("paddle"))
        {

            xSpeed = xSpeed * -ballSpeedIncreaseX;
            ySpeed = ySpeed * ballSpeedIncreaseY;
            mysteryCount += 1;
        }
        
    }
    //text
    private void LateUpdate()
    {
        scoreboard.text = player1Score.ToString() + " -"+ mysteryCount.ToString() +"- " + player2Score.ToString();
    }
}
