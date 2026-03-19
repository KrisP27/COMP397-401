using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button saveBtn;
    [SerializeField] private Button loadBtn;
    public void StartPlayGameSingle()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void Start()
    {
        saveBtn.onClick.AddListener(() =>
        {
            SaveLoadSystem.Instance.gameData.fileName = "Menu";
            SaveLoadSystem.Instance.gameData.sceneName = "SampleScene";
            SaveLoadSystem.Instance.SaveGame();
        });

        loadBtn.onClick.AddListener(() =>
        {
            SaveLoadSystem.Instance.LoadGame("Menu");
        });
    }
}
