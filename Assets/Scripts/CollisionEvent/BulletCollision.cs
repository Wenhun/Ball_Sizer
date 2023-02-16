using UnityEngine;
using Ball.Shoot;
using UnityEngine.Events;

namespace Ball.CollisionEvent
{
    [RequireComponent(typeof(Bullet))]
    public class BulletCollision : MonoBehaviour
    {
        [Header("VFX")]
        [SerializeField] ParticleSystem exploreVFX;
        [Header("Event")]
        [SerializeField] UnityEvent exploreEvent;

        bool isCollision;

        Bullet bullet;

        void Start()
        {
            bullet = GetComponent<Bullet>();
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Obstacle" && !isCollision)
            {
                isCollision = true;
                Infect(other);
                isCollision = false;
            }
            exploreEvent.Invoke();
        }

        //Event method
        public void SetExplorePosition()
        {
            exploreVFX.transform.position = transform.position;
            exploreVFX.transform.localScale = transform.localScale;
        }

        void Infect(Collider other)
        {
            other.GetComponent<CapsuleCollider>().radius = bullet.BulletSize;
            other.GetComponent<Infector>().isInfected = true;
        }
    }
}