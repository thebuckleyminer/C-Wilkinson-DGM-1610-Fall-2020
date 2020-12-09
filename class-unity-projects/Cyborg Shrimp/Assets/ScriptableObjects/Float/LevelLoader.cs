using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class LevelLoader : ScriptableObject
{
    public void OnLoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
