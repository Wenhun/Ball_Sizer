using UnityEngine;

namespace Ball.Rear
{    
    public class Pointer : MonoBehaviour
    {
        [Header("Prefabs")]
        [SerializeField] Transform bullet;
        [SerializeField] Transform aimBall;

        Vector3 closerTarget;

        void Update()
        {
            if (bullet.gameObject.activeSelf)
            {
                RaycastHit hit;

                Physics.SphereCast(bullet.position, bullet.localScale.y/2, bullet.transform.right, out hit);
                
                if(hit.transform != null)
                {
                    closerTarget = hit.transform.position;
                    aimBall.position = closerTarget;
                    aimBall.localScale = bullet.localScale;
                }
            }
            else
            {
                aimBall.position = bullet.position;
            }
        }
    }
}