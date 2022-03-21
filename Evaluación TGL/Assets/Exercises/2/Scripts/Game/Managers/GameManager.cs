using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        private bool _isOnPause;

        public void Pause(bool state)
        {
            _isOnPause = state;
        }
    }
}
