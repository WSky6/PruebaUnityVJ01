using UnityEngine;
using System.Collections;

public class SpeedPowerUp : MonoBehaviour
{
    private MeshRenderer renderer;
    private Collider powerUpCollider;
    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        powerUpCollider = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Player_movement movement = other.GetComponent<Player_movement>();
            if(movement != null)
            {
                movement.IncreaseSpeed();
                StartCoroutine(RespawnSpeed());
            }
        }
    }
    private IEnumerator RespawnSpeed()
    {
        renderer.enabled = false;
        powerUpCollider.enabled = false;
        yield return new WaitForSeconds(10f);
        renderer.enabled = true;
        powerUpCollider.enabled = true;
    }
}
