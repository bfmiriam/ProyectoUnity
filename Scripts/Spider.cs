using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{
    public Animator anim;
    private CharacterController controller;

    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    //Las otras funciones de Collision con collions box o capsula no funcionaban porque al tener el personaje "player" un
    //character controller y usarlo no es collider es HIT por lo que el personaje detecta si ha recibido un hit, pero los modelos no lo detectan como colision.
    // PD en el script del personaje he cambiado el tipo de colision con las monedas , y sigue funcionando, pero es algo diferente.


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            Debug.Log("Te ha matado la araña");
            anim.Play("Bite");
           
        }
        if (hit.gameObject.tag == "Rock")
        {
            anim.Play("deathNormal");
            

        }
    }
}