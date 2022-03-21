using UnityEngine;

namespace DefaultNamespace
{
    public class ExitButton : MonoBehaviour
    {
        public void OnClickExit()
        {
            //DO Exit
        }

        public bool IsActive()
        {
            return gameObject.activeInHierarchy;
        }
    }
}