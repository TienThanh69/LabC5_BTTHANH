using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // Hàm này chạy khi Player va chạm vật lý với vật thể khác
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Đã va chạm với: " + collision.gameObject.name);
    }

    // Hàm này chạy khi Player đi xuyên qua một vật thể có Is Trigger được tích
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Đã đi xuyên qua (Trigger): " + other.gameObject.name);
    }
}