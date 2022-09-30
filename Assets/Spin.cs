using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    Vector3  speed;
    Vector3 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(0f, -1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //from https://answers.unity.com/questions/1721211/accessing-the-transform-of-a-child-gameobject-of-m.html
        Rigidbody[] rbs = gameObject.GetComponentsInChildren<Rigidbody>();
        for (int i = 0; i < rbs.Length; i++)
        {
                if(rbs[i].gameObject != gameObject && rbs[i] != rigidbody)
                {
                        speed = rbs[i].angularVelocity;
                }
        }
        rigidbody.angularVelocity = speed;
    }
}
