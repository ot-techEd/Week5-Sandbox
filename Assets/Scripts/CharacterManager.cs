using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public Material[] materialsHead;
    public Material[] materialsBody;

    private int headNumberSaved;
    private int bodyNumberSaved;

    private PlayerCustomisation playerCustomisation;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        playerCustomisation = FindObjectOfType<PlayerCustomisation>();
    }

    public void ApplyMaterialToCharacter(int headNumber, int bodyNumber)
    {
        headNumberSaved = headNumber;
        bodyNumberSaved = bodyNumber;
        playerCustomisation.SetPlayerCustomisation(materialsHead[headNumber], materialsBody[bodyNumber]);
    }

    public void ApplyMaterialToCharacter()
    {
        if (playerCustomisation == null)
        {
            playerCustomisation = FindObjectOfType<PlayerCustomisation>();
        }

        playerCustomisation.SetPlayerCustomisation(materialsHead[headNumberSaved], materialsBody[bodyNumberSaved]);
    }
}
