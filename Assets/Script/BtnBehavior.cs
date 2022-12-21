using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BtnBehavior : MonoBehaviour, IVirtualButtonEventHandler
{

    [SerializeField] private GameObject mascot;
    VirtualButtonBehaviour virtualBtn;
    // Start is called before the first frame update
    void Start()
    {
        virtualBtn = GetComponentInChildren<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);
    }


    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonBehaviour vb)
    {
        mascot.SetActive(true);
    }

    void IVirtualButtonEventHandler.OnButtonReleased(VirtualButtonBehaviour vb)
    {
        mascot.SetActive(false);
    }
}
