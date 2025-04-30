using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using System.Linq;


public class Teleport : MonoBehaviour
{
    [SerializeField]Transform[] teleport;
    private void Start() {
        teleport = GameObject.FindGameObjectsWithTag("points")
                                .Select(go => go.transform)
                                .ToArray();
    }
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
