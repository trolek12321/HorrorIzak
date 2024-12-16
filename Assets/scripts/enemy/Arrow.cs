using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace enemy
{
public class Arrow : MonoBehaviour
{
    [SerializeField] private float damage = 2f;
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.health -= damage;
            Debug.Log("Strzała trafiła gracza!");
            Destroy(gameObject);
        }
        else if(collision.gameObject.TryGetComponent<enemy>(out enemy enemy))
        {}
        else
        {
            Destroy(gameObject);
        }
    }
}
}
