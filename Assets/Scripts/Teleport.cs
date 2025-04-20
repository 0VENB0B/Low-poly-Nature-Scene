using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]Transform[] teleport;
    void Update(){
        for (int i = 0; i < teleport.Length; i++){
            if (Input.GetKeyDown(KeyCode.Alpha0 + i) || Input.GetKeyDown(KeyCode.Keypad0 + i)){
                if (teleport[i] != null){
                    transform.position = teleport[i].position;
                    
                }
            }            
        }
    }
}
