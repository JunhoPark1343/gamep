using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform palyerTransform;
    Vector3 Offset;

    void Awake()
    {
        palyerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - palyerTransform.position;
    }
    void LateUpdate()
    {
        transform.position = palyerTransform.position+Offset;
    }
}
