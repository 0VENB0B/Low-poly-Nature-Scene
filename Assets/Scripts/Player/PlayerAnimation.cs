using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField]float speed;
    [SerializeField]Animator animatorController;
    void Start(){
        rb = GetComponent<Rigidbody>();
        
    }
    void Update(){
        speed = rb.velocity.magnitude;
        if (speed > 2){
            animatorController.SetBool("IsMoving", true);
        }else{
            animatorController.SetBool("IsMoving", false);

        }
    }
}
