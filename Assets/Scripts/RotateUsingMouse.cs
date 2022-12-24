using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUsingMouse : MonoBehaviour
{
    public float rotationSpeed = 1f;
    // Start is called before the first frame update
   
    void OnMouseDrage()
    {
        float XaxisRatation = Input.GetAxis("Mouse X") * rotationSpeed;

        float YaxisRatation = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.Rotate(Vector3.down,XaxisRatation);
        transform.Rotate(Vector3.right, YaxisRatation);

    }
}
