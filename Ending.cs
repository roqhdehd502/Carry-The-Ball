using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#pragma warning disable 0618

public class Ending : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Application.LoadLevel("Title"); // 엔터키 입력시 Title Scene으로 넘어갑니다.
        }
    }
}