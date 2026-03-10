using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MagnusSoccerKick : MonoBehaviour
{
    [SerializeField] private float kickForce = 1.0f;
    [SerializeField] private float spinAmount = 1.0f;
    [SerializeField] private float magnusStrength = 0.5f;

    private Rigidbody rb;
    bool isShot = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isShot == false)
        {
            rb.AddForce(Vector3.forward * kickForce, ForceMode.Impulse);

            rb.AddTorque(Vector3.up * spinAmount);

            isShot = true;
        }
    }

    private void FixedUpdate()
    {
        if (isShot == false) { return; }

        Vector3 velocity = rb.linearVelocity;
        Vector3 spin = rb.angularVelocity;

        Vector3 magnusForce = magnusStrength * Vector3.Cross(spin, velocity);

        rb.AddForce(magnusForce);
    }
}
