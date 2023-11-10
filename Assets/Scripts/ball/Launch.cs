using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    private bool atLaunchpad= false;
    [SerializeField]private float launchForce = 0f;
    private Rigidbody rb;
    public float forceIncrease = 250f;
    public GameObject launchpad;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (atLaunchpad) {
            if (Input.GetKey(KeyCode.Space)) {
                launchForce += Time.deltaTime * forceIncrease;
            }
            if (Input.GetKeyUp(KeyCode.Space)) {
                rb.AddForce(launchpad.transform.up * launchForce);
                launchForce= 0f;
            }
        }

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Launchpad")atLaunchpad = true;        
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Launchpad")atLaunchpad = false;         
    }
}
