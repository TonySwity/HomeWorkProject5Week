using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    [SerializeField] private Transform _cameraTransform;


    private void Update()
    {
        Vector3 toCam = transform.position - _cameraTransform.position;
        transform.rotation = Quaternion.LookRotation(toCam);
    }
}
