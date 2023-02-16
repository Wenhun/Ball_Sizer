using UnityEngine;
using UnityEngine.UI;

namespace Ball.GameStatus
{
    [RequireComponent(typeof(SizeCheck))]
    public class SizeBar : MonoBehaviour
    {
        [Header("UI Elements")]
        [SerializeField] Image bar;

        float maxBarValue;
        float minimumScale;

        SizeCheck sizeCheck;

        bool isCorrectConfigured = false;

        void Awake()
        {
            //Parameters Check
            if(bar.type == Image.Type.Filled & bar.fillMethod == Image.FillMethod.Horizontal)
            {
                isCorrectConfigured = true;
            }
            else
            {
                Debug.LogError("Object: " + bar.name + " -> Parameters Are Incorrectly Configured: \n" + 
                    "Required Type: Filled; Required FillMethod: Horizontal");
            }
        }

        void Start()
        {
            sizeCheck = GetComponent<SizeCheck>();
            minimumScale = sizeCheck.MinimumScale;
            maxBarValue = transform.localScale.y - minimumScale;
            bar.color = Color.green;
        }

        void LateUpdate()
        {
            if(!isCorrectConfigured) return;
            BarChange();
        }

        void BarChange()
        {
            bar.fillAmount = (transform.localScale.y - minimumScale) / maxBarValue;

            if (bar.fillAmount >= 0.2f && bar.fillAmount <= 0.6f)
            {
                bar.color = Color.yellow;
            }
            
            if (bar.fillAmount < 0.2f)
            {
                bar.color = Color.red;
            }
        }
    }
}