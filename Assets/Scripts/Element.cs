using Assets.Scripts;
using Interfaces;
using UnityEngine;

public class Element : MonoBehaviour
{
    private ITrajectory _trajectory;
    private Rect LimitViewport;
    private float startPosX;
    private float startPosY;
    private GameManager _gameManager;

    private void Awake()
    {
        Activate(false);
    }

    private void Start()
    {
        LimitViewport = new Rect(-1f, -1f, 3f, 3f);

        startPosX = transform.position.x;
        startPosY = transform.position.y;
    }

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
    }

    public void SetTrajectory(ITrajectory trajectory)
    {
        _trajectory = trajectory;
    }

    private void Update()
    {
        if (!LimitViewport.Contains(Camera.main.WorldToViewportPoint(transform.position)))
        {
            Activate(false);
        }

        transform.position = _trajectory.AxisMovement(transform.position.x, transform.position.y, startPosX, startPosY,
            GeneralGameValues.SlowTimeStarted);
    }

    public void Activate(bool pActivar)
    {
        enabled = pActivar;
    }
}