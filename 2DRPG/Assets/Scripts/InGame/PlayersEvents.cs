using System;
using UnityEngine;

public class PlayersEvents : MonoBehaviour
{
    public event Action<int> OnPickUpHealtPotion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "HealthPotion")
        {
            print("OnCillisionEn");
            OnPickUpHealtPotion?.Invoke(5);
            collision.gameObject.SetActive(false);
        }

    }
}
