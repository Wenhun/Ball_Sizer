using UnityEngine;

namespace Ball.GameStatus
{
    [RequireComponent(typeof(Animator))]
    public class DoorOpen : MonoBehaviour
    {
        [Header("Player Ball")]
        [SerializeField] Transform player;
        [Header("Preferences")]
        [SerializeField] float openDistance = 5f;

        Animator animator;

        void Start()
        {
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            float distanceToPlayer = Mathf.Abs(player.transform.position.x - transform.position.x);
            if(distanceToPlayer <= openDistance)
            {
                animator.SetTrigger("Open");
                this.enabled = false;
            }
        }
    }
}
