using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCustomisationInput : MonoBehaviour
{
    private CharacterManager characterManager;
    private int tempHeadValue;
    private int tempBodyValue;


    private void Start()
    {
        characterManager = FindObjectOfType<CharacterManager>();
    }
    // Update is called once per frame
    void Update()
    {
        //For Head value
        if (Input.GetKeyDown(KeyCode.A))
        {
            tempHeadValue = 0;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            tempHeadValue = 1;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            tempHeadValue = 2;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            tempHeadValue = 3;
        }

        //For Body Value
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            tempBodyValue = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            tempBodyValue = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            tempBodyValue = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            tempBodyValue = 3;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            characterManager.ApplyMaterialToCharacter(tempHeadValue, tempBodyValue);
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
    