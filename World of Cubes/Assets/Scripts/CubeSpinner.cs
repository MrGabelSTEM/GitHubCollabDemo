using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpinner : MonoBehaviour
{
    public float speed, x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        x = Time.deltaTime * speed * x;
        y = Time.deltaTime * speed * y;
        z = Time.deltaTime * speed * z;
    }

    // Update is called once per frame
    void Update()
    {
        RotateCube();
    }

    void RotateCube()
    {
        
        transform.Rotate(x, y, z, Space.Self);
    }
}
