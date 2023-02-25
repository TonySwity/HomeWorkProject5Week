using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PartSize : MonoBehaviour
{
    [SerializeField] private Transform _part;
    
    public void SetSize(float value)
    {
        _part.localScale = new Vector3(value, value, value);
    }
}
