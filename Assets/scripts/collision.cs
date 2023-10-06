using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xSpeed = 3f;
    public float ySpeed = 3f;
    public int lOrR = 0;
    public int lOrR2 = 0;


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
        }else if (collision.gameObject.CompareTag("vertical"))
        {
        
            xSpeed = xSpeed * -1f;
        }

        
        
        if (collision.gameObject.CompareTag("paddle"))
        {

            xSpeed = xSpeed * -1f;
        }

    }
}
