using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyclemovement : MonoBehaviour
{
    public Transform player;
    public Transform cycle;
    public float speed = 50f;
    public CharacterController controller;
    public float omega = 12f;
    public Transform rotationaxis;
    bool isseated = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool fpress = Input.GetKey("f");
        bool epress = Input.GetKey("e");
        if (!isseated && fpress)
        {
            isseated = true;
        }
        if (isseated && epress)
        {
            isseated = false;
        }
        if (isseated)
        {
            bool wpress = Input.GetKey("w");
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            Vector3 move = -transform.right * z;
            controller.Move(move * speed * Time.deltaTime);
            
            if (wpress)
            {
                rotationaxis.Rotate(0, x * omega * Time.deltaTime, 0);
            }
        }
        
        
    }
}
