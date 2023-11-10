using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddExtraForce : MonoBehaviour
{
    private float forceModifier = 0;
    public float force = 100f;
   
    // Start is called before the first frame update
    void Start()
    {
        SetForceModifier.OnChangeModifier += ChangeModifier;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (forceModifier!=0) { 
            Vector3 explosionPosition = new Vector3();
            explosionPosition = collision.transform.position;
            explosionPosition.y -= collision.transform.localScale.y;
            explosionPosition.z -= collision.transform.localScale.z;

            Debug.Log(transform.up * force);
            //collision.rigidbody.AddRelativeForce(transform.up*force, ForceMode.Force);
            collision.rigidbody.AddForce(transform.up * (force * forceModifier));
            //collision.rigidbody.AddForce(0,force/2,force);            
        }
    }
    private void ChangeModifier(float modifier) { 
        forceModifier = modifier;
    }
   
}
