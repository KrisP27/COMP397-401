using UnityEngine;

public class AchievementSystem : MonoBehaviour
{
    [SerializeField] private VoidEventChannel voidChannel;
    [SerializeField] private GameDataEventChannel gameDataChannel;
    [SerializeField] private FloatEventChannel floatChannel;

    private int achievementJumps = 10;
    private int currentJumps = 0;

    private void OnEnable()
    {
        voidChannel.OnEventRaised += VoidEventCalled;
        gameDataChannel.OnEventRaised += GameDataEventCalled;
        floatChannel.OnEventRaised += FloatEventCalled;
    }

    private void OnDisable()
    {
        voidChannel.OnEventRaised -= VoidEventCalled;
        gameDataChannel.OnEventRaised -= GameDataEventCalled;
        floatChannel.OnEventRaised -= FloatEventCalled;
    }

    private void VoidEventCalled()
    {
        Debug.Log("Event Called by listening to the Event Channel of Void type");
        currentJumps++;

        if (currentJumps == achievementJumps)
        {
            Debug.Log("Achievement Completed. Jumped 10 Times");
        }
    }

    private void GameDataEventCalled(GameData data)
    {
        Debug.Log("Event Called by listening to the Event Channel of GameData type");
    }

    private void FloatEventCalled(float data)
    {
        Debug.Log("Event Called by listening to the Event Channel of Float type");
    }
}
