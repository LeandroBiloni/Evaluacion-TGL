using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class SceneController : MonoBehaviour
    {
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}

