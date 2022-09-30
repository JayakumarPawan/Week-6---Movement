using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{
    
    Rigidbody rigidbody;
    [SerializeField] float magnitude;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
	    rigidbody = GetComponent<Rigidbody>();
        direction = new Vector3(0,-1,0);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddTorque(direction * magnitude);
    }
}
