using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class botCollisionRight : MonoBehaviour
{
    //var 

    //direction and speed
    public float xPosition = 0f;
    public float yPosition = 0f;

    public float xSpeed = 3f;
    public float ySpeed = 3f;

    //random direction
    public int UOrD = 0;
    public int lOrR = 0;

    //text
    private GameObject scoreGameObject;
    private TMPro.TMP_Text scoreboard;
    private int player1Score;
    private int player2Score;
    private int winScore = 3;


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

    }

    // Update is called once per frame
    void Update()
    {

        //speed
        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;

        transform.position = new Vector3(xPosition, yPosition, 0f);

        //if someone scores 3 times they win
        if(player1Score >= winScore)
        {
            SceneManager.LoadScene("winScreenBot");
        } 
        if(player2Score >= winScore)
        {
            SceneManager.LoadScene("winScreenPlayer");
        }

        //you can stop by pressing esc
        if (Input.GetKey(KeyCode.Escape))
        {

            SceneManager.LoadScene("menu");
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
            xSpeed = 3f;

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
            xSpeed = -3f;
            ySpeed = -3f;

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


        //if paddle is hit: send ball other way and speed it up a bit
        if (collision.gameObject.CompareTag("paddle"))
        {

            xSpeed = xSpeed * -1.1f;
            ySpeed = ySpeed * 1.05f;
        }
        
    }
    //text
    private void LateUpdate()
    {
        scoreboard.text = player1Score.ToString() + " - " + player2Score.ToString();
    }
}
