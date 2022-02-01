using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyKeyToBegin : MonoBehaviour
{
    [SerializeField]
    float waitDurationForAnyKey;
    void Update()
    {
        if(Input.anyKey && Time.time > waitDurationForAnyKey)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}
