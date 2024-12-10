using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCoroutine : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        Debug.Log("Coroutine Start");

        yield return new WaitForSeconds(2);

        Debug.Log("2s has passed");

        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

        Debug.Log("Space pushed");
    }
}
