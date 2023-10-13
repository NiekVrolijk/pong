using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuGoTo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {

            SceneManager.LoadScene("collision");
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("menu");
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("menu");
        }
    }
}

