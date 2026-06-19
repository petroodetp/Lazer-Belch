using UnityEngine;

public class laser_mouvement : MonoBehaviour
{
    private float speed = 25.0f;
    Rigidbody2D rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        rigidbody.MovePosition(rigidbody.position + Vector2.up * speed * Time.fixedDeltaTime);
    }
}
