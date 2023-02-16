using UnityEngine;

namespace Ball.Rear
{
    public class Aim : MonoBehaviour
    {
        void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.tag == "Obstacle")
            {
                other.gameObject.GetComponent<SelectTarget>().IsSelected();
            }
        }

        void OnCollisionExit(Collision other)
        {
            if (other.gameObject.tag == "Obstacle")
            {
                other.gameObject.GetComponent<SelectTarget>().IsNotSelected();
            }
        }
    }
}