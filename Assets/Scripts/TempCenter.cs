using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempCenter : MonoBehaviour
{
    public static TempCenter Instance;

    private void Awake()
    {
        Instance = this;
    }
}
