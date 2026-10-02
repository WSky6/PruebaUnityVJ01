using UnityEngine;

public class EnemyBehavior_movement : MonoBehaviour
{
    [SerializeField] private GameObject EnemyBala;
    [SerializeField] private float velocidadX = 2f;
    [SerializeField] private float velocidadZ = 2f;
    [SerializeField] private int enemyType;
    private float velocidadXEnemy02 = 4f;

    private void Start()
    {
        InvokeRepeating("DispararBala", 0, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();
        EliminarEnemigo();
    }

    public void DispararBala()
    {
        Instantiate(EnemyBala, transform.position, transform.rotation);
    }

    public void EliminarEnemigo()
    {
        if (transform.position.z < -1.7f || transform.position.z > 44f || transform.position.x < -8.5f || transform.position.x > 8.5f)
        {
            Destroy(gameObject);
        }
    }

    public void moveEnemy()
    {
        switch (enemyType)
        {
            case 1:
                {
                    transform.Translate(velocidadX * Time.deltaTime, 0, velocidadZ * Time.deltaTime);
                break;
                }
            case 2:
                {
                    if(transform.position.x > 8f || transform.position.x < -8f)
                    {
                        velocidadXEnemy02 *= -1;
                    }
                    transform.Translate(velocidadXEnemy02 * Time.deltaTime, 0, 0);
                break;
                }
        }
    }
}
