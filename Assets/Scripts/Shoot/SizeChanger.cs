using UnityEngine;

namespace Ball.Shoot
{
    public class SizeChanger : MonoBehaviour
    {
        [Header("Prefabs")]
        [SerializeField] Transform player;
        [SerializeField] Transform bullet;
        [Header("Settings")]
        [SerializeField] float speedPlayerSizeChange = 3f;
        [SerializeField] float speedBulletSizeChange = 1f;

        public void ChangeSize()
        {
            if(bullet.gameObject.activeSelf)
            {
                player.localScale -= Vector3.one * Time.deltaTime / speedPlayerSizeChange;
                bullet.localScale += Vector3.one * Time.deltaTime / speedBulletSizeChange;
            }
        }
    }
}
