using Assets.Scripts;
using Assets.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class Element : MonoBehaviour
{
    private ITrajectory trayectoria;
    private Rect LimitViewport;
    private float startPosX;
    private float startPosY;

    private void Awake()
    {
        Activar(false);
    }
    private void Start()
    {
        LimitViewport = new Rect(-1f, -1f, 3f, 3f);

        startPosX = transform.position.x;
        startPosY = transform.position.y;
    }

    public void Initializer(GameManager pGameManager)
    {
    }

    public void SetTrayectoria(ITrajectory pTrayectoria)
    {
        trayectoria = pTrayectoria;
    }

    private void Update()
    {
        if (!LimitViewport.Contains(Camera.main.WorldToViewportPoint(transform.position)))
        {
            Activar(false);
        }

        transform.position = trayectoria.AxisMovement(transform.position.x, transform.position.y, startPosX, startPosY, GeneralGameValues.SlowTimeStarted);
    }

    public void Activar(bool pActivar)
    {
        enabled = pActivar;
    }
}
