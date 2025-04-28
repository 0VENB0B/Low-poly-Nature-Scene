using Unity.VisualScripting;
using UnityEngine;

public class Interact : MonoBehaviour {
    public Transform interactorSource;
    public float interactRange;
    private void Update() {
        if (Input.GetKeyDown(KeyCode.E)){
            Collider[] hitColliders = Physics.OverlapSphere(interactorSource.position, interactRange);
            foreach (Collider item in hitColliders){
                if (item.TryGetComponent(out IInteractable interactObj)){
                    interactObj.Interact();
                }
            }
        }
    }
    public IInteractable GetInteractable(){
        Collider[] hitCollider = Physics.OverlapSphere(interactorSource.position, interactRange);
        foreach (Collider item in hitCollider){
            if (item.gameObject.TryGetComponent(out IInteractable interactObj)){
                return interactObj;
            }
        }
        return null;
    }
    void OnDrawGizmos(){
        if (interactorSource == null) return;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactorSource.position, interactRange);
    }
}