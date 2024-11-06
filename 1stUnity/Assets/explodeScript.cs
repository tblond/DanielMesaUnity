using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeScript : MonoBehaviour
{
    Rigidbody rb;
    float explosionRadius = 30f;
    float explosionStrength = 10000f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(30*transform.forward,ForceMode.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Collider[] allVictimColliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in allVictimColliders)
        {
            Rigidbody rigidbody = collider.GetComponent<Rigidbody>();
            if (rigidbody != null)
            {
                rigidbody.AddExplosionForce(explosionStrength,transform.position, explosionRadius);
            }
        }

        Destroy(gameObject);
    }


}
