using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;

    public float xSpeed = 3f;
    public float ySpeed = 3f;


    public int lOrR = 0;
    public int lOrR2 = 0;


    //public TMP_Text score1;
    //public string score2 = "0|0";
    //public int scoreLeft = 0;
    //public int scoreRight = 0;

    // Start is called before the first frame update
    void Start()
    {
        //score1.text = score2;

        transform.position = new Vector3(xPosition, yPosition, 0f);
        var lOrR = Random.Range(0, 2);
        if (lOrR == 0)
        {
            ySpeed = ySpeed * -1f;
        }
        var lOrR2 = Random.Range(0, 2);
        if (lOrR2 == 0)
        {
            xSpeed = xSpeed * -1f;
        }

    }

    // Update is called once per frame
    void Update()
    {


        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;

        transform.position = new Vector3(xPosition, yPosition, 0f);

        //if (scoreLeft == 1 && scoreRight == 0)
        //{
        //    score2 = "1|0";
        //}
        //else if (scoreLeft == 2 && scoreRight == 0)
        //{
        //    score2 = "2|0";
        //}

        //if (scoreRight == 1 && scoreLeft == 0)
        //{
        //    score2 = "0|1";
        //}
        //else if (scoreRight == 2 && scoreLeft == 0)
        //{
        //    score2 = "0|2";
        //}

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("horizontal"))
        {
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("vertical1"))
        {
            xSpeed = xSpeed * -1f;
            xPosition = 0f;
            yPosition = 0f;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //scoreRight += 1;
}
        else if (collision.gameObject.CompareTag("vertical2"))
        {
            xSpeed = xSpeed * -1f;
            xPosition = 0f;
            yPosition = 0f;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //scoreLeft += 1;
        }



        if (collision.gameObject.CompareTag("paddle"))
        {

            xSpeed = xSpeed * -1.05f;
            ySpeed = ySpeed * 1.01f;
        }

    }
}
