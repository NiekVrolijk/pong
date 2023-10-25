using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mWinScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
    //if enter is pressed it goes back to pong :)
    if (Input.GetKey(KeyCode.Return))
    {

         SceneManager.LoadScene("mysteryPong");
    } else if (Input.GetKey(KeyCode.Backspace))
        {
            SceneManager.LoadScene("menu");
        }

        if (Input.GetKey(KeyCode.Escape))
        {

            SceneManager.LoadScene("menu");
        }
    }
}
