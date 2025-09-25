using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadBhuwanScene()  => SceneManager.LoadScene("BhuwanScene");
    public void LoadVarshitScene() => SceneManager.LoadScene("VarshitScene");
}
