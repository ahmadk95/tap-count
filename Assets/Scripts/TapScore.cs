using TMPro;
using UnityEngine;

public class TapScore : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;

    private int _score = 0;

    private void Start()
    {
        _score = PlayerPrefs.GetInt("taps", 0);
        SetScore();
    }

    public void OnTap()
    {
        _score++;
        SetScore();
    }

    private void SetScore()
    {
        ScoreText.text = _score.ToString();
        PlayerPrefs.SetInt("taps", _score);
        PlayerPrefs.Save();
    }
}
