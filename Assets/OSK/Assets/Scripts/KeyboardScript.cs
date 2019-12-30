using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class KeyboardScript : MonoBehaviour
{

    //public delegate void SendMessage(object source, EventArgs args, string s);
    //public event SendMessage MessageSent;

    public event EventHandler<string> OnMessageSent;

    public InputField TextField;
    public GameObject RusLayoutSml, RusLayoutBig, EngLayoutSml, EngLayoutBig, SymbLayout;
    public string text = "";
    public enum keyboard_types { CODE_KEYBOARD, CLUES_KEYBOARD };
    public keyboard_types Keyboard_Type;

    public void alphabetFunction(string alphabet)
    {

        TextField.text=TextField.text + alphabet;
        text += alphabet;

    }

    public void BackSpace()
    {

        if(TextField.text.Length>0) TextField.text= TextField.text.Remove(TextField.text.Length-1);

    }

    public void CloseAllLayouts()
    {

        RusLayoutSml.SetActive(false);
        RusLayoutBig.SetActive(false);
        EngLayoutSml.SetActive(false);
        EngLayoutBig.SetActive(false);
        SymbLayout.SetActive(false);

    }

    public void ShowLayout(GameObject SetLayout)
    {

        CloseAllLayouts();
        SetLayout.SetActive(true);

    }

    public void Send_Text()
    {
        OnMessageSentHandler();
        text = "";
        TextField.text = ""; 
    }

    protected virtual void OnMessageSentHandler()
    {
            Debug.Log("Message sent: " + text);
            OnMessageSent?.Invoke(this,text);   
    }

}
