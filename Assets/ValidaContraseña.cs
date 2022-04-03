using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValidaContraseña : MonoBehaviour
{
    
    string contraseñaCorrecta;
    public Text ingresoUsuario;
    string contraseñaUsuario;
    public Text textoMsj;
    public GameObject cartelitoMsj;

    void Start()
    {
        contraseñaCorrecta="12345";
        cartelitoMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void ValidarContraseña()
        {
            contraseñaUsuario=ingresoUsuario.text;

            if (contraseñaUsuario==contraseñaCorrecta)
            {
                cartelitoMsj.SetActive(true);
                
                Debug.Log("Bienvenido");
            }

            else
            {
                cartelitoMsj.SetActive(true);
                textoMsj.text="Contraseña incorrecta";
                Debug.Log ("Contraseña incorrecta");
            }
        }
    
}
