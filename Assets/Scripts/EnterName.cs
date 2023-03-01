using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnterName : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;


    public void SetName(string txt)
    {
        _text.text = txt;
    }
}
