using UnityEngine;

namespace Ball.Mover
{
    public class WayChanger : MonoBehaviour
    {
        [Header("Player Ball")]
        [SerializeField] Transform player;

        Vector3 startSize;

        void Start()
        {
            startSize = transform.localScale;
        }

        void Update()
        {
            transform.localScale = new Vector3(startSize.x, startSize.y, player.localScale.z / 10); //10 - is difference between scale
        }
    }
}