using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#pragma warning disable 0649
#pragma warning disable 0618

public class ItemController : MonoBehaviour
{
    public GameObject itemPrefeb;
    public GameObject itemContainer;

    private void OnTriggerEnter(Collider item)
    {
        if (item == null) return;

        Application.LoadLevel("Ending"); // Ball 오브젝트가 Item 오브제와 충돌시 트리거가 발생하여, Ending Scene으로 넘어갑니다.
    }
}