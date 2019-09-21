// Inspiration: Unity docs https://docs.unity3d.com/ScriptReference/CharacterController.Move.html
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    public float gravity = 20f;
    public float mouseSpeed = 90f;

    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        //Movement
        Vector3 moveDirection = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= speed;

        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);

        //Camera
        transform.Rotate(0, Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime, 0f);
        Camera.main.transform.Rotate(-Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime, 0f, 0f);
    }
}