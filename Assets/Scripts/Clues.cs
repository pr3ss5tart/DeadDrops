using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clues : MonoBehaviour
{
    public List<string> clues;

    public void Show_Clues()
    {
        foreach(string c in clues)
        {
            Debug.Log(c + "\n");
        }
    }

    public void OnMessageReceived(object source, string message)
    {
        Debug.Log("Message Received: " + message);
        clues.Add(message);
    }

}
