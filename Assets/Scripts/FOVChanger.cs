using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class FOVChanger : MonoBehaviour
{
    [SerializeField] Volume volume;
    private DepthOfField dof;
    [SerializeField] FirstPersonController firstPersonController;
    public float targetStart;
    public float targetEnd;
    private void Start() {
        volume = GameObject.FindGameObjectWithTag("Volumn").GetComponent<Volume>();
    }
    private void Update() {
        if (firstPersonController.isZoomed){
            if (volume.profile.TryGet(out dof)){
                dof.gaussianStart.value = Mathf.Lerp(dof.gaussianStart.value, targetStart, firstPersonController.zoomStepTime * Time.deltaTime);
                dof.gaussianEnd.value = Mathf.Lerp(dof.gaussianStart.value, targetStart, firstPersonController.zoomStepTime * Time.deltaTime);
            }
            
        }else{
            if (volume.profile.TryGet(out dof)){
                dof.gaussianStart.value = Mathf.Lerp(dof.gaussianStart.value, 100f, firstPersonController.zoomStepTime * Time.deltaTime);;
                dof.gaussianEnd.value = Mathf.Lerp(dof.gaussianStart.value, 100f, firstPersonController.zoomStepTime * Time.deltaTime);;
            }
        }
    }
}
