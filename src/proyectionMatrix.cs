using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectionMatrix : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    void Start()
    {
        Debug.Log(cam.previousViewProjectionMatrix);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
