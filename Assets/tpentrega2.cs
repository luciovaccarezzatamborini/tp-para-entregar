using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tpentrega2 : MonoBehaviour
{
    string contraseñacorrecta;
    string contraseñausuario;
     public Text textoingresado;
    public GameObject cartel_msj;
    public Text textomsj;

    // Start is called before the first frame update
    void Start()
    {
        contraseñacorrecta = "12345";
        cartel_msj.SetActive(false);
        
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
            cartel_msj.SetActive(true);
            textomsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartel_msj.SetActive(true);
            textomsj.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }


}
