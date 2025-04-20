using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInside : MonoBehaviour
{
    public GameObject UIShow;
    public Transform TargetPos;
    void OnTriggerStay(Collider other){
        UIShow.SetActive(true);
        if (other.gameObject.CompareTag("Player")){
            if (Input.GetKeyDown(KeyCode.E)){
                GameObject.FindGameObjectWithTag("Player").transform.position = TargetPos.position;
            }
        }
    }
    void OnTriggerExit(Collider other){
        if (other.gameObject.CompareTag("Player")){
            UIShow.SetActive(false);
        }
    }
}
