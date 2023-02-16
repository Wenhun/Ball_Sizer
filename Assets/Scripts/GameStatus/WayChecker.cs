using UnityEngine;
using UnityEngine.Events;
using Ball.Mover;

namespace Ball.GameStatus
{
    public class WayChecker : MonoBehaviour
    {
        [SerializeField] UnityEvent wayClear;

        void FixedUpdate()
        {
            RaycastHit hit;
            
            Physics.SphereCast(transform.position, transform.localScale.y / 2, transform.right, out hit);
            
            if(hit.transform.tag == "Finish")
            {
                wayClear.Invoke();
            }
        }
    }
}