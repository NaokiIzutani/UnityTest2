using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = new Vector3(0.0f, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.W)) { vel.z += 0.5f; }
        if (Input.GetKey(KeyCode.S)) { vel.z -= 0.5f; }
        if (Input.GetKey(KeyCode.A)) { vel.x -= 0.5f; }
        if (Input.GetKey(KeyCode.D)) { vel.x += 0.5f; }
        transform.position += vel;
    }
}
