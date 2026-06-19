using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    static public PlayerScore Instance;
    public int Score = 0;
    private void Awake()
    {
        if (Instance != null)
            Destroy(this);
        Instance = this;
    }

    [SerializeField] private TMP_Text text;

    private void Update()
    {
        text.SetText($"score : {Score}");
    }
}
