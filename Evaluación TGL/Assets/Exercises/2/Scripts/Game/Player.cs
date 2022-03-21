using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private float _playerLife;

    private bool _isOnGround;

    public void OnReceiveDamage(float damage)
    {
        _playerLife -= damage;

        if (_playerLife <= 0)
        {
            //TODO Death
            Debug.Log("The player is dead");
        }
    }

    public void Jump()
    {
        if (_isOnGround)
        {
            //TODO Jump
        }
    }
}
