using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2D : MonoBehaviour
{
    //Esta propiedad permite que se vea en el inspector siendo private
    [SerializeField] 

    //Si pongo public se vuelve visible en el inspector de Unity (No es buena idea ponerlo en public)
    float moveSpeed;
    //float moveSpeed{get; set;} si lo ponemos asi no se vera en el inspector



    void Update()
    {
        //Se mueve a la derecha muy rapido
        transform.Translate(Axis * moveSpeed * Time.deltaTime);

    }

    //Funcion devuelve algo, metodos son los void's (esta es la foma correcta de hacer una funcion mas practica)
    Vector2 Axis
    {

        get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); //Aqui pones lo que quieres regresar
    
    }

    //Encapsulamiento
    public float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }



    /* Esta no
    Vector2 Axis2()
    {
        return new Vector2();
    }
    */


}
