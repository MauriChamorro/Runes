using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Interfaces
{
    public interface ITrajectory
    {
        Vector2 AxisMovement(float x, float y, float pStarPosX, float pStarPosY, float VelChange);
        ITrajectoryValues Values { get; }
    }
}
