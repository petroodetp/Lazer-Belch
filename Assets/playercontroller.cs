using UnityEngine;
using UnityEngine.InputSystem;

public class playercontrols : MonoBehaviour
{
    private Vector2 dir;
    [SerializeField] private float speed = 1.0f;
    private Rigidbody2D rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = new Vector2();
        newPos.x = rigidbody.position.x + dir.x * Time.fixedDeltaTime * speed;

        rigidbody.MovePosition(new Vector3(newPos.x, newPos.y, 1));
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        dir = context.ReadValue<Vector2>();

    }
}



