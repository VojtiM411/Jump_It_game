using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;

    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }

    void FixedUpdate()
    {
        //moving
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
