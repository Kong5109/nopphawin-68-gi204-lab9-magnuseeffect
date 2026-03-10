using UnityEngine;

public class TorqueRotate : MonoBehaviour
{
    [SerializeField] private float torquePower = 5f;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.AddTorque(Vector3.right * torquePower);
    }
}
