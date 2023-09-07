using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBtm : MonoBehaviour
{

    public void SpriteSelect()
    {
        gameManager.I.SpriteSelect(transform.name);
    }

}
