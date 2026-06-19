using UnityEngine;

public class Ennemi_Movement : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;
    private Rigidbody2D rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.MovePosition(rigidbody.position + Vector2.down * speed * Time.fixedDeltaTime );
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<destroyer>() != null)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            PlayerScore.Instance.Score += 1;
        }
    }
}
