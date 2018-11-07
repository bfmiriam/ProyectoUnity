using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 moveVector;
    public Animator anim;

    private float speed = 5.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;

    private float animationDuration = 3.0f;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time < animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }

        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        if (Input.GetKeyDown("space"))
        {
            anim.Play("jumpBite_RM");

        }
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Menu");
        }

            //x - Izquierda y derecha
            moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        //y - Arriba y abajo
        moveVector.y = verticalVelocity;
        //z - alante y atras
        moveVector.z = speed;

        controller.Move(moveVector * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.point.z > transform.position.z + controller.radius)
        {
            anim.Play("death");
            speed = 0.0f;
        }
    }
}
  

