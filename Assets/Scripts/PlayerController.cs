using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float sprint = 1f;
    private Vector3 velocity;

    private bool groundedPlayer;
    private float jumpHeight = 1.0f;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform headCheck;
    [SerializeField] private LayerMask groundMask;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        PlayerMove();
        Sprint();
        IntoTheVoid();
    }

    void PlayerMove()
    {
        RaycastHit hit;
        groundedPlayer = Physics.Raycast(groundCheck.position, transform.TransformDirection(Vector3.down), out hit, 0.1f, groundMask);

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * x * -1 + transform.right * y;
        characterController.Move(move * speed * sprint * Time.deltaTime);

        if (groundedPlayer)
        {
            if (velocity.y < 0)
            {
                velocity.y = 0f;
            }

            if (Input.GetButtonDown("Jump"))
            {
                velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * -9.81f);
            }
        }

        velocity.y += -9.81f * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }

    void Sprint()
    {
        if (Input.GetKey(KeyCode.LeftShift)) sprint = 2f; else if (Input.GetKey(KeyCode.LeftControl)) sprint = 0.5f; else sprint = 1f;
    }

    void IntoTheVoid()
    {
        if (transform.position.y < -10) transform.position = new Vector3(0, 20, 0);
    }
}
