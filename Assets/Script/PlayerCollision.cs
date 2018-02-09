
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerHp playerHp;
    public AudioSource effect;
    public ButtonController2 controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enermy"))
        {
            playerHp.DamageHp(1);
                effect.Play();
            Destroy(other.gameObject);
        }
    }
}
