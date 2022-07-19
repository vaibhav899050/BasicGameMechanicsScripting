using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyclecamerarotate : MonoBehaviour
{
    public float mouseSensitivity = 250f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * mouseSensitivity * Time.deltaTime, 0);
    }
}
