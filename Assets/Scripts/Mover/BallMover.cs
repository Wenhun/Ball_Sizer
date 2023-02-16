using UnityEngine;

namespace Ball.Mover
{
    [RequireComponent(typeof(Rigidbody))]
    public class BallMover : MonoBehaviour
    {
        [Header("Finish Point")]
        [SerializeField] Transform finish;
        [Header("Preferences")]
        [SerializeField] float jumpForce = 12f;
        [SerializeField] float moveSpeed = 1f;

        bool canMove = false;

        Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            if(canMove)
            {
                Vector3.MoveTowards(transform.position, finish.position, Time.deltaTime * moveSpeed);
            }
        }

        void OnCollisionStay(Collision other)
        {
            if(canMove)
            {
                rb.velocity = Vector3.zero;
                rb.AddForce(Vector3.up * jumpForce);
                rb.AddForce(Vector3.right * jumpForce/2);
            }
        }
        
        public void CanMove()
        {
            canMove = true;
            rb.AddForce(Vector3.up);
        }
    }
}