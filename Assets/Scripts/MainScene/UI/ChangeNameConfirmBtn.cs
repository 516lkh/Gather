using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNameConfirmBtn : MonoBehaviour
{
    public void ChangeNameConfirm()
    {
        string name = transform.parent.Find("Name").GetComponent<TMP_InputField>().text;
        transform.parent.gameObject.SetActive(false);
        if(name != "") gameManager.I.ChangeNameConfirm(name);
    }
}
