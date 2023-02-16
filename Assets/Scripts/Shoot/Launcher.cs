using UnityEngine;

namespace Ball.Shoot
{
    [RequireComponent(typeof(SizeChanger))]
    public class Launcher : MonoBehaviour
    {
        [SerializeField] Bullet bullet;

        SizeChanger sizeChanger;

        void Start()
        {
            sizeChanger = GetComponent<SizeChanger>();
            bullet.gameObject.SetActive(false);
        }

        void Update()
        {
            if (Input.touchCount > 0 && !bullet.isLaunch)
            {
                switch (Input.GetTouch(0).phase)
                {
                    case TouchPhase.Began:
                        bullet.gameObject.SetActive(true);
                        break;
                    case TouchPhase.Ended:
                        bullet.Shoot();
                        break;
                    default:
                        sizeChanger.ChangeSize();
                        break;
                }   
            }
        }
    }
}
