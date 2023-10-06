using System.Collections;
using System.Collections.Generic;
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
    public Text score;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
        var lOrR = Random.Range(0, 2);
        if(lOrR == 0)
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

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("horizontal")) 
        {
            ySpeed = ySpeed * -1f;
        }else if (collision.gameObject.CompareTag("vertical1"))
        {
            xSpeed = xSpeed * -1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (collision.gameObject.CompareTag("vertical2"))
        {
            xSpeed = xSpeed * -1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }



        if (collision.gameObject.CompareTag("paddle"))
        {

            xSpeed = xSpeed * -1.05f;
            ySpeed = ySpeed * 1.01f;
        }

    }
}
