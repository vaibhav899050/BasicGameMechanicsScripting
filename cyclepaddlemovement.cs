using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyclepaddlemovement : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        bool wpress = Input.GetKey("w");
        if (wpress)
        {
            animator.SetBool("wpress", true);
        }
        if (!wpress)
        {
            animator.SetBool("wpress", false);
        }
    }
}
