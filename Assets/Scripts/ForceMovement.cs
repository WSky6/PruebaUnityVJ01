using UnityEngine;

public class ForceMovement : MonoBehaviour
{
    [SerializeField] private float fuerza = 10f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * fuerza);
        }
    }
}
