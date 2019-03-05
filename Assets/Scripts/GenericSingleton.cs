using UnityEngine;

public class GenericSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance = null;
    private static readonly object padlock = new object();

    public static T Instance { get { return _instance; } private set { _instance = value; } }

    protected virtual void Awake()
    {
        if (_instance == null)
        {
            lock (padlock)
            {
                if (_instance == null)
                {
                    _instance = this as T;
                    DontDestroyOnLoad(this.gameObject);
                }

            }
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }


}
