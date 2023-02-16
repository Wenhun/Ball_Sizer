using UnityEngine;

namespace Ball.Rear
{
    [RequireComponent(typeof(MeshRenderer))]
    public class SelectTarget : MonoBehaviour
    {
        [SerializeField] Material selectMaterial;

        Material normalMaterial;

        MeshRenderer mR;

        void Start()
        {
            mR = GetComponent<MeshRenderer>();
            normalMaterial = mR.material;
        }

        public void IsSelected()
        {
            mR.material = selectMaterial;
        }

        public void IsNotSelected()
        {
            mR.material = normalMaterial;
        }
    }
}