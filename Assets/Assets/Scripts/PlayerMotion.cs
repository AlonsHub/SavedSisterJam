using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    /// <summary>
    /// Also handles INPUT? shouldn't really
    /// </summary>
    [SerializeField]
    float moveSpeed;
 
    
    void Update()
    {
        Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (inputVector.magnitude > 1)
            inputVector.Normalize();

        inputVector *= moveSpeed * Time.deltaTime;

        transform.Translate(inputVector, Space.Self);
    }
}
