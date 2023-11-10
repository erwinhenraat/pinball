using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bump : MonoBehaviour
{

    public float force = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            float offsetx = Random.Range(0, 1f);
            float offsetz = Random.Range(0, 1f);
            Vector3 offPos= transform.position;
            offPos.x += offsetx;
            offPos.z += offsetz;

            rb.AddExplosionForce(force, offPos, transform.localScale.x + 1.5f);
        }
        
    }
}
