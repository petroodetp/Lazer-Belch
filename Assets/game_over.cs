using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class game_over : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] TMP_Text text;

    public void GameOver()
    {
        image.gameObject.SetActive(true);
        text.SetText("Game Over " +
            $" Score : {PlayerScore.Instance.Score}");

    }

    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
