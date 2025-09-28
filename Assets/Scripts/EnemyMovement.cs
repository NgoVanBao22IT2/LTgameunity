using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f; // Tốc độ di chuyển
    public float patrolDistance = 3f; // Khoảng cách di chuyển qua lại
    private float startPositionX; // Vị trí ban đầu trên trục X
    private bool movingRight = true; // Hướng di chuyển ban đầu

    void Start()
    {
        startPositionX = transform.position.x; // Lưu vị trí ban đầu
    }

    void Update()
    {
        // Di chuyển qua lại trong khoảng cách đã định
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= startPositionX + patrolDistance)
            {
                movingRight = false; // Đổi hướng khi vượt quá giới hạn phải
            }
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= startPositionX - patrolDistance)
            {
                movingRight = true; // Đổi hướng khi vượt quá giới hạn trái
            }
        }
    }
}
