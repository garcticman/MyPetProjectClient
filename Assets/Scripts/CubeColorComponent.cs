using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CubeColorComponent : MonoBehaviour
{
    private void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>(); 
        
        var propertyBlock = new MaterialPropertyBlock();
        
        meshRenderer.GetPropertyBlock(propertyBlock);
        propertyBlock.SetColor("_Color", Random.ColorHSV());
        meshRenderer.SetPropertyBlock(propertyBlock);
    }
}