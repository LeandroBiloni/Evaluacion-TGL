using UnityEngine;

namespace Buttons
{
    public abstract class BaseButton : MonoBehaviour
    {
        public abstract void OnClick();
        public bool IsActive()
        {
            return gameObject.activeInHierarchy;
        }
    }
}
