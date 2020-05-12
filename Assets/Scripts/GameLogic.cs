using UnityEngine;

public class GameLogic : MonoBehaviour
{
    private static GameLogic _gameLogic;

    public static GameLogic GetGameLogic()
    {
        return _gameLogic;
    }

    public void Awake()
    {
        if (_gameLogic != null)
        {
            Destroy(_gameLogic.gameObject);
        }

        _gameLogic = this;
        DontDestroyOnLoad(this);
    }

    [SerializeField]
    private float Score = 0.0f;

    public void IncrementScore(float score)
    {
        Score += score;
    }
}