using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    KeyboardScript kbs;
    public string bombCode;
    public string guess;
    public int guessesLeft=3;
    // Start is called before the first frame update
    void Start()
    {
        kbs = GetComponent<KeyboardScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Get_Code()
    {
        bombCode = kbs.code;
    }

    public void Check_Code()
    {
        if((guess == bombCode) && (guessesLeft > 0))
        {
            //Stop timer and defuse nuke
        }else if (guessesLeft > 0)
        {
            guessesLeft--;
        }
        else
        {
            //End game, show nuke effect
        }
    }
}
