using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Transform verRot;
    private Transform horRot;

    // Use this for initialization
    void Start () {
        verRot = transform.parent;
        horRot = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        Camera();
    }
    void Camera()
    {
        float X_Rotation = Input.GetAxisRaw("Mouse X");
        float Y_Rotation = Input.GetAxisRaw("Mouse Y");
        verRot.transform.Rotate(0, -X_Rotation, 0);
        horRot.transform.Rotate(Y_Rotation, 0, 0);
    }
}
