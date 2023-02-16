using UnityEngine;

namespace Ball.GameStatus
{
    public class TrafficLightController : MonoBehaviour
    {
        [Header("Lights")]
        [SerializeField] Light green;
        [SerializeField] Light red;

        void Start()
        {
            red.enabled = true;
            green.enabled = false;
        }

        public void SwitchLight()
        {
            red.enabled = false;
            green.enabled = true;
        }
    }
}