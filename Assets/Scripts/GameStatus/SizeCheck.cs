using UnityEngine;
using UnityEngine.Events;

namespace Ball.GameStatus
{
    public class SizeCheck : MonoBehaviour
    {
        [Header("End Game Event")]
        [SerializeField] UnityEvent looseEvent;
        [Header("Preferences")]
        [SerializeField] float minimumScale = 0.1f;

        public float MinimumScale { get => minimumScale; }  

        void Update()
        {
            if (transform.localScale.y <= minimumScale)
            {
                looseEvent.Invoke();
            }
        }
    }
}