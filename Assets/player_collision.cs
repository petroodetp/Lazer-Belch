using UnityEngine;

public class player_collision : MonoBehaviour
{
    [SerializeField] private game_over obj;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Ennemi_Movement>() != null)
        {
            Destroy(gameObject);
            obj.GameOver();
        }
    }
}
