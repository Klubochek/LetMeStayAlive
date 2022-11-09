using UnityEngine;

public class SaveButton : MonoBehaviour
{
    private PlayerData pd;
    private PlayerCurrentState currentState;
    private Vector3 playerPosition;


    public void ButtonSave()
    {
        currentState = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCurrentState>();
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position;
        pd = new PlayerData();
        pd.health = currentState.Health;
        pd.playerPosition = playerPosition;
        DataManager.SavePlayerData(pd);

    }

}
