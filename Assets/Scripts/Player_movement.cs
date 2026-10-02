using UnityEngine;
using System.Collections;

public class Player_movement : MonoBehaviour
{
    [SerializeField]private float velocity = 5f;
    private Vector3 direccion = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    public void playerMovement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float profundidad = Input.GetAxisRaw("Vertical");

        direccion = new Vector3(horizontal, 0f, profundidad);

        Vector3 desplazamiento = direccion.normalized * velocity * Time.deltaTime;
        transform.Translate(desplazamiento, Space.World);
    }
    public void IncreaseSpeed()
    {
        StartCoroutine(CooldownSpeed());
    }
    private IEnumerator CooldownSpeed()
    {
        velocity += 5f;
        yield return new WaitForSeconds(5f);
        velocity -= 5f;
    }
}
