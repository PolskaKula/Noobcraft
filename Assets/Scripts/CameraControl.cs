using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 50f;
    private Transform playerBody;
    [SerializeField] private Transform head;
    [SerializeField] private Transform body;
    private float xRotation = 0f;
    //private float yRotation = 90f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerBody = transform.parent;
    }

    void Update()
    {
        //transform.position = new Vector3(body.position.x, body.position.y + 0.45f, body.position.z);
        CameraRotation();
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        xRotation -= mouseY * mouseSensitivity * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 90f, 0f);

        playerBody.Rotate(Vector3.up * mouseX * mouseSensitivity * Time.deltaTime);
    }
}
