using UnityEngine;
using UnityEngine.Events;

namespace Ball.GameStatus
{
    public class CrossingDoorTrigger : MonoBehaviour
    {
        [SerializeField] UnityEvent winEvent;

        void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Player")
            {
                winEvent.Invoke();
            }
        }
    }
}
