using UnityEngine;
using UnityEngine.InputSystem;

public class player_shoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnPoint;

    void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject obj = Instantiate(bullet, spawnPoint.position, transform.rotation);
        }
    }
}
