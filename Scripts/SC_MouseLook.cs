using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Lock cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
