using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace VRLibrary
{
    [RequireComponent(typeof(XRBaseInteractable))]
    public class VRInteractable : MonoBehaviour
    {
        private XRBaseInteractable interactable;

        private void Awake()
        {
            interactable = GetComponent<XRBaseInteractable>();
        }

        private void OnEnable()
        {
            interactable.selectEntered.AddListener(OnGrab);
        }

        private void OnDisable()
        {
            interactable.selectEntered.RemoveListener(OnGrab);
        }

        private void OnGrab(SelectEnterEventArgs args)
        {
            Debug.Log("Item grabbed in VR!");
        }
    }
}
