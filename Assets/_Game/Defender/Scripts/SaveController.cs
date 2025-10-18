using UnityEngine;

public class SaveController : MonoBehaviour
{
    public void ClearSave()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }

    public static void SaveLevel(int level)
    {
        PlayerPrefs.SetInt(Constants.Level, level);
        PlayerPrefs.Save();
    }

    public static void SaveCrystals(int crystals)
    {
        PlayerPrefs.SetInt(Constants.Crystals, crystals);
        PlayerPrefs.Save();
    }
}