using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] private game_over obj;
    [SerializeField] private GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<Ennemi_Movement>() != null)
        {
            Destroy(collision.gameObject);
            Destroy(player);
            obj.GameOver();
        }
    }
}