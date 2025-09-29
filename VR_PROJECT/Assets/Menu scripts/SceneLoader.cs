using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Call these from your UI buttons
    public void LoadBhuwanScene()
    {
        SceneManager.LoadScene("BhuwanScene", LoadSceneMode.Single);
    }

    public void LoadVarshitScene()
    {
        SceneManager.LoadScene("VarshitScene", LoadSceneMode.Single);
    }
}
