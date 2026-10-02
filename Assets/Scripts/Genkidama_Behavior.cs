using UnityEngine;
using System.Collections;

public class Genkidama_Behavior : MonoBehaviour
{
    [SerializeField] private bool isEnabled = true;
    [SerializeField] private float cooldown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && isEnabled==true)
        {
            StartCoroutine(Cooldown());
        }
    }

    private IEnumerator Cooldown()
    {
        //Aqui instanciamos la Genkidama y le damos un tiempo de espera para que no se pueda volver a instanciar hasta que pase el tiempo de cooldown
        Invoke("GenkidamaPower", 0f);
        GenkidamaPower();
        isEnabled = false; //Desactivamos la habilidad

        Debug.Log("Cooldown de la Genkidama deshabilitado");
        yield return new WaitForSeconds(cooldown); //Tiempo de Espera
        isEnabled = true; //Vuelve a activar la habilidad
        Debug.Log("Cooldown de la Genkidama habilitado");
    }

    private void GenkidamaPower()
    {
        Debug.Log("Lanzamiento de la Genkidama");
    }
}
