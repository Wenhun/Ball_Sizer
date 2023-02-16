using UnityEngine;

namespace Ball.Shoot
{
    public class Bullet : MonoBehaviour
    {
        [Header("Player Ball")]
        [SerializeField] Transform player;
        [Header("Preferences")]
        [SerializeField] float bulletSpeed = 5f;

        public bool isLaunch {get; set;}
        public float BulletSize { get => transform.localScale.y; }

        Vector3 startPosition;
        Vector3 startScale;

        void Start()
        {
            startPosition = transform.position;
            startScale = transform.localScale;
        }

        void Update()
        {
            if(isLaunch) transform.Translate(transform.right * Time.deltaTime * bulletSpeed);
        }

        public void Shoot()
        {
            if(gameObject.activeSelf) isLaunch = true; 
        }

        public void ResetBullet()
        {
            transform.position = startPosition;
            transform.localScale = startScale;
        }
    }
}