using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimaciones : MonoBehaviour
{

    Animator animator;

    void Awake() {
        animator = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        bool caminar = Input.GetKey(KeyCode.LeftControl);
        animator.SetBool("Caminar", caminar);
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("Atacar");
        }
    }
}
