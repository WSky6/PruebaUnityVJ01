using UnityEngine;

public class BalaBehavior : MonoBehaviour
{
    [SerializeField] private float velocidadZ = 5f;

    // Update is called once per frame
    void Update()
    {
        distanciaBala();
    }

    public void distanciaBala()
    {
        transform.Translate(0, 0, velocidadZ * Time.deltaTime);

        if (transform.position.z < -1.7f || transform.position.z > 44f || transform.position.x < -8.5f || transform.position.x > 8.5f)
        {
            Destroy(gameObject);
        }
    }
}
