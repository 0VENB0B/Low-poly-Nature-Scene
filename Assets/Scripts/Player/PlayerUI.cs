using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]Interact interactor;
    public GameObject interactUI;
    void Update(){
        if (interactor.GetInteractable() != null){
            interactUI.SetActive(true);
        }else{
            interactUI.SetActive(false);

        }
    }
}
