using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float rapidez;
    [SerializeField]private float velocidadRotacion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rapidez = 5f;
        velocidadRotacion = 90f;
    }

    // Update is called once per frame
    void Update()
    {
        float avance = Input.GetAxisRaw("Vertical");
        float giro = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.forward * avance * rapidez * Time.deltaTime, Space.World);
        transform.Rotate(0f, giro * velocidadRotacion * Time.deltaTime, 0f, Space.World);
    }
}
