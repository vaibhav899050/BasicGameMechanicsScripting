using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    Animator animator;
    bool isseated = false 

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
        bool wpress = Input.GetKey("w");
        bool shiftpress = Input.GetKey("left shift");
        bool fpress = Input.GetKey("f");
        bool epress = Input.GetKey("e");
        if (wpress && !isseated)
        {
            animator.SetBool("wpress", true);
        }
        if (!wpress && !isseated)
        {
            animator.SetBool("wpress", false);
        }
        if (shiftpress && !isseated)
        {
            animator.SetBool("shiftpress", true);
        }
        if (!shiftpress && !isseated)
        {
            animator.SetBool("shiftpress", false);
        }
        if (wpress && shiftpress && !isseated)
        {
            animator.SetBool("wpress", true);
            animator.SetBool("shiftpress", true);
        }
        if (fpress && !isseated)
        {
            animator.SetBool("fpress", true);
            isseated = true;
        }
        if (fpress && !isseated && !wpress)
        {
            animator.SetBool("fpress", true);
            isseated = true;
        }
        if (isseated && wpress)
        {
            animator.SetBool("cyclewpress", true);
        }
        if (isseated && !wpress)
        {
            animator.SetBool("cyclewpress", false);
        }
        if (isseated && epress)
        {
            animator.SetBool("fpress", false);
            isseated = false;
        }
        



    }
}
