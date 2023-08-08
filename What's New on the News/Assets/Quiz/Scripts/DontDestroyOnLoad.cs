using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    private static bool created = false;

    private void Awake()
    {
        if (!created)
        {
            // Don't destroy this object when loading new scenes
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            // Destroy duplicate instances
            Destroy(this.gameObject);
        }
    }
}
