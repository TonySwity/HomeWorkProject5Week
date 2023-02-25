using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SizePartsToText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private string _text;

    private void Start()
    {
        Slider slider = GetComponentInParent<Slider>();
        _textMeshPro.text = _text + slider.value;
    }

    public void ShowCurrentSize(float value)
    {
        _textMeshPro.text = _text + value.ToString("0.0");
    }
}
