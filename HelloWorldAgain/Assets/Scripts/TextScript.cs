using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    
    public Text newText;

    //hey im a comment
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("space"))
        {
            newText.text = "Hello, my name is Taylor Howard!";
        }   


         if (Input.GetKeyUp("space"))
        {
            newText.text = "Hello World!";
        }   

        if (Input.GetKey("escape"))
        
        {
            Application.Quit();
        }

    }
}
