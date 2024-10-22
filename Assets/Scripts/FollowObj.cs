using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObj : MonoBehaviour
{
    [SerializeField] Vector3 offsite;
    [SerializeField] Transform obj;
    [SerializeField] bool useAngle;
    Transform mTransform;
    private void Start()
    {
        mTransform = transform;
    }
    void Update()
    {
        mTransform.position = obj.position + offsite;
        if(useAngle) mTransform.rotation = obj.rotation;
    }
}
