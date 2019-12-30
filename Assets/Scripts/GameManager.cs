using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Set these to serializable-fields
    [SerializeField]
    Code code_script;
    [SerializeField]
    Clues clues_script;
    [SerializeField]
    GameObject WriteCodeMenu;
    [SerializeField]
    GameObject WriteCluesMenu;
    void Start()
    {
        KeyboardScript[] kbs = FindObjectsOfType<KeyboardScript>();

        foreach(KeyboardScript kb in kbs)
        {
            if(kb.Keyboard_Type == KeyboardScript.keyboard_types.CODE_KEYBOARD)
                kb.OnMessageSent += code_script.OnCodeReceived;
            else if (kb.Keyboard_Type == KeyboardScript.keyboard_types.CLUES_KEYBOARD)
                kb.OnMessageSent += clues_script.OnMessageReceived;
        }

        WriteCodeMenu.SetActive(true);
        WriteCluesMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //TESTING PURPOSES
        if (Input.GetKey(KeyCode.Space))
        {
            WriteCodeMenu.SetActive(false);
            WriteCluesMenu.SetActive(true);
        }
    }
}
