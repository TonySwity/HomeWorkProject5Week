using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
    [SerializeField] private Transform _middleTargetTransform;
    [SerializeField] private Transform _topTargetTransform;
    [SerializeField] private Transform _capTargetTransform;
    
    [SerializeField] private Transform _middlePartTransform;
    [SerializeField] private Transform _topPartTransform;
    [SerializeField] private Transform _capTransform;
    
    private void Update()
    {
        _middlePartTransform.position = _middleTargetTransform.position;
        _topPartTransform.position = _topTargetTransform.position;
        _capTransform.position = _capTargetTransform.position;
    }
}
