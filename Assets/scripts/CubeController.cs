using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Camera Camera;
    private Rigidbody m_RigidBody;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("helloWorld");
        m_RigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0)){
            Debug.Log("Click");
            Debug.Log(Input.mousePosition);
            var ray = Camera.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray.origin);
            if (Physics.Raycast(ray, out var hitInfo)){
                Debug.Log("Hit something!");
                Debug.Log(hitInfo);
                m_RigidBody.AddForce(ray.direction*200f);
            }
        }
    }
}
