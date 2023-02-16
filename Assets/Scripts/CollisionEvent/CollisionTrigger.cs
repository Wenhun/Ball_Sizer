using UnityEngine;

namespace Ball.CollisionEvent
{
    public class CollisionTrigger : MonoBehaviour
    {
        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Obstacle")
            {
                other.gameObject.GetComponent<Infector>().isInfected = true;
            }
        }
    }
}