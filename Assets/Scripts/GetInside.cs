using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInside : MonoBehaviour,IInteractable
{
    public Transform TargetPos;
    public void Interact(){
        GameObject.FindGameObjectWithTag("Player").transform.position = TargetPos.position;
    }
}
