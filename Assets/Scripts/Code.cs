using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Code : MonoBehaviour
{
    public string bombCode;
    public string guess;
    public int guessesLeft=3;

    public void OnCodeReceived(object source, string code)
    {
        Debug.Log("bomb code: " + code);
        bombCode = code;
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
