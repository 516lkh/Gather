using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacterConfirmBtn : MonoBehaviour
{
    public void ChangeCharacterConfirm()
    {
        gameManager.I.ChangeCharacterConfirm(this.name);
        transform.parent.gameObject.SetActive(false);
    }
}
