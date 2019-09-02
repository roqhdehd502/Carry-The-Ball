using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#pragma warning disable 0649

public class BallCam : MonoBehaviour
{
    [SerializeField]
    public GameObject targetCamera;
    public GameObject targetObject;

    private Vector3 offset; // 카메라와 타겟 사이의 거리

    private void Start()
    {
        offset = targetCamera.transform.position - targetObject.transform.position;
        // 거리 = 타겟카메라의 트랜스폼의 포지션(위치)빼기 타겟오브젝트의 트랜스폼의 위치
    }

    private void Update()
    {
        cameraTarget(); // 카메라 타겟 설정
    }

    
    private void cameraTarget()
    {
        targetCamera.transform.position = offset + targetObject.transform.position;
        // 타겟 카메라 위치 설정 (거리 + 타겟오브젝트의 위치)
    }
}