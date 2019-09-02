using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#pragma warning disable 0618

public class Title : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            Application.LoadLevel("Play"); // 엔터키 입력시 Play Scene으로 넘어갑니다.
        }
    }
}