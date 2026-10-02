using UnityEngine;

public class Cylinder_rotation : MonoBehaviour
{
    private float velocidadRotacion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        velocidadRotacion = 90f;
    }

    // Update is called once per frame
    void Update()
    {
        float giro = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0f, giro * velocidadRotacion * Time.deltaTime, 0f, Space.World);

        //transform.Rotate(0, 30f * Time.deltaTime, 0f, Space.World);
    }
}
