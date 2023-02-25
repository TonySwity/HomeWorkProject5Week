using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCaps : MonoBehaviour
{
    [SerializeField] private List<GameObject> _caps;


    public void SetCaps(int index)
    {
        for (int i = 0; i < _caps.Count; i++)
        {
            _caps[i].SetActive(i == index);
        }
    }
}
