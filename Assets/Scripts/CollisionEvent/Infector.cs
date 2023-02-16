using UnityEngine;

namespace Ball.CollisionEvent
{
    [RequireComponent(typeof(MeshRenderer))]
    public class Infector : MonoBehaviour
    {
        [Header("Materials")]
        [SerializeField] Material infectedMaterial;
        [Header("Preferences")]
        [SerializeField] float timeToDestroy = 1f;

        public bool isInfected { get; set; }

        MeshRenderer meshRenderer;

        void Start()
        {
            meshRenderer = GetComponent<MeshRenderer>();
        }

        void Update()
        {
            if(isInfected)
            {
                meshRenderer.material = infectedMaterial;
                Destroy(gameObject, timeToDestroy);
            }
        }
    }
}