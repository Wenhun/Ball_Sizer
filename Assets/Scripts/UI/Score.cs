using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Ball.UI
{
    public class Score : MonoBehaviour
    {
        [Header("UI elements")]
        [SerializeField] TMP_Text scoreText;
        [SerializeField] Image barSize;
        [Header("Preferences")]
        [SerializeField] int maxScore = 1000;

        int score;

        void Start()
        {
            score = maxScore;
        }

        void LateUpdate()
        {
            score = (int)(maxScore * barSize.fillAmount);
            scoreText.text = score.ToString();
        }
    }
}