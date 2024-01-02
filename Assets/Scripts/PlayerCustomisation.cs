using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCustomisation : MonoBehaviour
{
    [SerializeField] private MeshRenderer headRenderer;
    [SerializeField] private MeshRenderer bodyRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerCustomisation(Material headRd, Material bodyRd)
    {
        headRenderer.material = headRd;
        bodyRenderer.material = bodyRd;
    }
}
