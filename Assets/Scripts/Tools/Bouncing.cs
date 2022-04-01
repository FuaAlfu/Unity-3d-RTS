using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.4.1
/// </summary>

public class Bouncing : MonoBehaviour
{
    [SerializeField]
    private float bounceForce = 3.2f;

    Rigidbody rb;
    Vector3 bounce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bounce = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision c)
    {
        BouncingAttempt();
    }

    private void BouncingAttempt()
    {
        rb.AddForce(bounce * bounceForce, ForceMode.Impulse);
    }
}
