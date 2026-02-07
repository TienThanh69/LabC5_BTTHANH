using UnityEngine;
public class Conveyor3D : MonoBehaviour
{
    public float speed = 2.0f;
    void OnCollisionStay(Collision collision)
    {
        // Đẩy vật thể đứng trên nó về phía trước
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        if (rb != null) { rb.linearVelocity = transform.forward * speed; }
    }
}