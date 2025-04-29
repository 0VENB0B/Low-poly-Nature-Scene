using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampInteract : MonoBehaviour, IInteractable
{
    [SerializeField]GameObject LampLight;
    [SerializeField]Material closeLampMat,openLampMat;
    [SerializeField]bool isEnable;
    [SerializeField]Renderer _renderer;
    public void Interact(){
        if (isEnable){
            _renderer.material = closeLampMat;
            LampLight.SetActive(false);
            isEnable = false;
        }else{
            _renderer.material = openLampMat;
            LampLight.SetActive(true);
            isEnable = true;

        }
    }
}
