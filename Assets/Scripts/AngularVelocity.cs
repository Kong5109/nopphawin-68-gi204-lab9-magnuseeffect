using UnityEngine;
using UnityEngine.InputSystem;

public class AngularVelocity : MonoBehaviour
{
    [SerializeField] private float angularSpeed = 5f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            Vector3 direction = Vector3.up * angularSpeed;
            rb.angularVelocity = direction;
        }else if (Keyboard.current.aKey.wasReleasedThisFrame)
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
