using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyclesitplayer : MonoBehaviour
{
    
    
    public GameObject player;
    public Transform cycle;
    Animator animator;
    public CharacterController controller1;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float cyclexposition = cycle.position.x;
        float cycleyposition = cycle.position.y;
        float cyclezposition = cycle.position.z;
        float playerxposition = transform.position.x;
        float playeryposition = transform.position.y;
        float playerzposition = transform.position.z;
        float xMove = playerxposition - cyclexposition;
        float zMove = playerzposition - cyclezposition;
        bool fpress = Input.GetKey("f");
        if (fpress)
        {
            
            
            
            Vector3 move = transform.right * xMove + transform.forward * zMove;
            controller1.Move(move);

        }
        
    }
}
