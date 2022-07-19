using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
    Animator animato;
    // Start is called before the first frame update
    void Start()
    {
        animato = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animato.SetBool("pressw", true);
        }
        if (!Input.GetKey("w"))
        {
            animato.SetBool("pressw", false);
        }
    }
}
