using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ball.UI
{
    public class ReloadLevel : MonoBehaviour
    {
        public void ReloadScene()
        {
            SceneManager.LoadScene(0);
        }
    }
}