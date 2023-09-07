using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public TMP_InputField Name;

    public void CreateCharacter()
    {

        gameManager.I.CreateCharacter(Name.GetComponent<TMP_InputField>().text, 1);
        //gameManager.I.CreateCharacter("asdf", 1);
    }
}
