using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
#pragma warning disable 0649
#pragma warning disable 0618

public class BallController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody ballRigid; // 리지드 바디 불러오기

    Vector3 speed = new Vector3();

    void Start()
    {
        ballRigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    private void Move() // 공의 움직임
    {
        if (Input.GetKey(KeyCode.W))
            ballRigid.AddForce(Vector3.forward * 20f, ForceMode.Acceleration);
        if (Input.GetKey(KeyCode.A))
            ballRigid.AddForce(Vector3.left * 20f, ForceMode.Acceleration);
        if (Input.GetKey(KeyCode.S))
            ballRigid.AddForce(Vector3.back * 20f, ForceMode.Acceleration);
        if (Input.GetKey(KeyCode.D))
            ballRigid.AddForce(Vector3.right * 20f, ForceMode.Acceleration);
    }

    void FixedUpdate() // 공의 물리적 처리
    {
        ballRigid.velocity = Vector3.Lerp(ballRigid.velocity, speed, 2f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel("Ending");
    }
}