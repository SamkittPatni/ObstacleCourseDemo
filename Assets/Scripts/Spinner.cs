using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, 3f, 0);
    }
}
