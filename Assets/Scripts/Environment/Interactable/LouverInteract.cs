using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LouverInteract : MonoBehaviour,IInteractable
{
    [SerializeField] Transform[] AllLouver;
    [SerializeField] Quaternion Open,Close;
    [SerializeField] bool isOpen;
    [SerializeField] float animationDuration;

    public void Interact(){
        if (isOpen){
            StopAllCoroutines();
            foreach (var item in AllLouver){
                StartCoroutine(RotateOverTime(item, item.localRotation, Close));
            }
            isOpen = false;
        }
        else{
            StopAllCoroutines();
            foreach (var item in AllLouver){
                StartCoroutine(RotateOverTime(item, item.localRotation, Open));
            }
            isOpen = true;
        }
    }

    private IEnumerator RotateOverTime(Transform target, Quaternion startRot, Quaternion endRot){
        float elapsed = 0f;

        while (elapsed < animationDuration){
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / animationDuration);
            target.localRotation = Quaternion.Slerp(startRot, endRot, t);
            yield return null;
        }

        target.localRotation = endRot;
    }
}
