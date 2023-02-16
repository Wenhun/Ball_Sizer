using UnityEngine;
using Ball.Shoot;

namespace Ball.Rear
{
    [RequireComponent(typeof(Bullet))]
    public class BulletMover : MonoBehaviour
    {
        [Header("Preferences")]
        [SerializeField] float swipeSpeed = 0.1f;
        [SerializeField] float trackSize = 3f;

        Touch touch;
        Bullet bullet;

        void Start()
        {
            bullet = GetComponent<Bullet>();
        }

        void Update()
        {
            if (Input.touchCount > 0 && !bullet.isLaunch)
            {
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved)
                {
                    transform.position = new Vector3(
                        transform.position.x,
                        transform.position.y,
                        ClampTouchPosition(transform.position.z));
                }
            }
        }

        float ClampTouchPosition(float position)
        {
            return Mathf.Clamp((position + touch.deltaPosition.x * -swipeSpeed), -trackSize, trackSize);
        }
    }
}