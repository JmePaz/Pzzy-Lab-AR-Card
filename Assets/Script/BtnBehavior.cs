using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BtnBehavior : MonoBehaviour, IVirtualButtonEventHandler
{

    [SerializeField] private Transform mascot;
    VirtualButtonBehaviour virtualBtn;
    // Start is called before the first frame update
    void Start()
    {
        virtualBtn = GetComponentInChildren<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);
    }


    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Working");
        mascot.Translate(Vector3.up * 10f * Time.deltaTime);
        
    }

    void IVirtualButtonEventHandler.OnButtonReleased(VirtualButtonBehaviour vb)
    {
       // mascot.SetActive(false);
    }
}
