using TMPro;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI currentHP;
    private PlayerCurrentState currentState;



    void Start()
    {

        currentState = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCurrentState>();
        currentState.OnHpChanged += ShowCurrentHP;
        currentHP.text = currentState.Health + $"/{currentState.MAXHEALTH}";
    }

    private void ShowCurrentHP(int hp)
    {
        currentHP.text = hp.ToString() + $"/{currentState.MAXHEALTH}";
    }

}
