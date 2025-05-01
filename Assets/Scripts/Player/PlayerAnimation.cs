using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class PlayerAnimation : NetworkBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField]float speed;
    [SerializeField]Animator animatorController;
    public Transform rightHandTarget;
    void Start(){
        rb = GetComponent<Rigidbody>();
        
    }
    void Update(){
        if (!isLocalPlayer) return;
        speed = rb.velocity.magnitude;
        if (speed > 2){
            animatorController.SetBool("IsMoving", true);
        }else{
            animatorController.SetBool("IsMoving", false);

        }
    }

}
