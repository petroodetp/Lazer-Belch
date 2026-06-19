using UnityEngine;
using UnityEngine.Rendering;

public class wall : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<destroyer>() != null)
            Destroy(collision.gameObject);
    }
}
