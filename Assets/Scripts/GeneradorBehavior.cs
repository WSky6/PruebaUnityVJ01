using UnityEngine;

public class GeneradorBehavior : MonoBehaviour
{
    [SerializeField] private GameObject enemy01;
    [SerializeField] private GameObject enemy02;
    [SerializeField] private float TiempoInicio;
    [SerializeField] private float TiempoGeneracion;
    [SerializeField] private int enemyType;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("GenerarEnemigo01", TiempoInicio, TiempoGeneracion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerarEnemigo01()
    {
        typeEnemy();
    }

    public void typeEnemy()
    {
        switch(enemyType)
        {
            case 1:
                {
                    Instantiate(enemy01, transform.position, transform.rotation);
                }
            break;
            case 2:
                {
                    Instantiate(enemy02, transform.position, transform.rotation);
                }
            break;
        }
    }
}
