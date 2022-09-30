using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Rigidbody copyobj;
    Vector3 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(0f, -1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.angularVelocity = copyobj.angularVelocity;
    }
}
