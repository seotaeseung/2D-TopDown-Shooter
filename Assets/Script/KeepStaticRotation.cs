using UnityEngine;

public class KeepStaticRotation : MonoBehaviour
{
    Quaternion initialRotation;

    void Start()
    {
        initialRotation = transform.rotation;
    }

    void LateUpdate()
    {
        transform.rotation = initialRotation;
    }
}
