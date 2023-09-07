using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

enum Sprite { doctor, lizard, wizard }


public class gameManager : MonoBehaviour
{

    public static gameManager I;

    public GameObject Player;

    public GameObject StartUI;
    public TMP_Text textMeshPro;

    public GameObject CharacterBtn;
    public GameObject SelectPanel;

    public RuntimeAnimatorController doctor;
    public RuntimeAnimatorController lizard;
    public RuntimeAnimatorController wizard;

    public GameObject ChangeNamePanel;
    public GameObject ChangeCharacterPanel;


    private void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateCharacter(string name, int character)
    {
        textMeshPro.text = name;
        Player.SetActive(true);
        StartUI.SetActive(false);

    }

    public void OpenSpriteSelect()
    {
        SelectPanel.SetActive(true);
        CharacterBtn.SetActive(false);
    }

    public void SpriteSelect(string objectname)
    {
        switch(objectname)
        {
            case "Btn1":
                Player.transform.Find("MainSprite").GetComponent<Animator>().runtimeAnimatorController = doctor;
                CharacterBtn.transform.Find("doctor").gameObject.SetActive(true);
                CharacterBtn.transform.Find("lizard").gameObject.SetActive(false);
                CharacterBtn.transform.Find("wizard").gameObject.SetActive(false);
                break;
            case "Btn2":
                Player.transform.Find("MainSprite").GetComponent<Animator>().runtimeAnimatorController = lizard;
                CharacterBtn.transform.Find("doctor").gameObject.SetActive(false);
                CharacterBtn.transform.Find("lizard").gameObject.SetActive(true);
                CharacterBtn.transform.Find("wizard").gameObject.SetActive(false);
                break;
            case "Btn3":
                Player.transform.Find("MainSprite").GetComponent<Animator>().runtimeAnimatorController = wizard;
                CharacterBtn.transform.Find("doctor").gameObject.SetActive(false);
                CharacterBtn.transform.Find("lizard").gameObject.SetActive(false);
                CharacterBtn.transform.Find("wizard").gameObject.SetActive(true);
                break;
        }
        SelectPanel.SetActive(false);
        CharacterBtn.SetActive(true);
    }

    public void ChangeName()
    {
        if (ChangeNamePanel.activeSelf)
            ChangeNamePanel.SetActive(false);
        else ChangeNamePanel.SetActive(true);
    }

    public void ChangeNameConfirm(string name)
    {
        textMeshPro.text = name;
    }

    public void ChangeCharacter()
    {
        if (ChangeCharacterPanel.activeSelf)
            ChangeCharacterPanel.SetActive(false);
        else ChangeCharacterPanel.SetActive(true);
    }

    public void ChangeCharacterConfirm(string objectName)
    {
        switch (objectName)
        {
            case "Doctor":
                Player.transform.Find("MainSprite").GetComponent<Animator>().runtimeAnimatorController = doctor;
                break;
            case "Lizard":
                Player.transform.Find("MainSprite").GetComponent<Animator>().runtimeAnimatorController = lizard;
                break;
            case "Wizard":
                Player.transform.Find("MainSprite").GetComponent<Animator>().runtimeAnimatorController = wizard;
                break;
        }
    }
}
