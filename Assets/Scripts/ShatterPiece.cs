using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterPiece : MonoBehaviour
{
    public AudioSource shatterSound;
    public float despawnTime;
    public float radius;
    public float power;

    void Start()
    {
        shatterSound.Play();
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(power, transform.position, radius, power/2);
            }
        }
        StartCoroutine("despawn");
    }

    IEnumerator despawn()
    {
        yield return new WaitForSeconds(despawnTime);
        Destroy(gameObject);
    }
}
