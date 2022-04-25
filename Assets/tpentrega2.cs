using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tpentrega2 : MonoBehaviour
{
    string contraseñacorrecta;
    string contraseñausuario;
    Text textoingresado;

    // Start is called before the first frame update
    void Start()
    {
        contraseñacorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarcontra()
    {
        contraseñausuario = textoingresado.text;

        if(contraseñausuario == contraseñacorrecta)
        {
            Debug.Log("Bienvenido");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }


}
