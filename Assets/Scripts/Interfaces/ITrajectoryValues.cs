namespace Assets.Scripts.Interfaces
{
    public interface ITrajectoryValues
    {
        float DirectionX { get; }
        float DirectionY { get; }
        float VelDesplX { get; }
        float VelDesplY { get; }
        float OscillationX { get; }
        float OscillationY { get; }
        float VelOscillationX { get; }
        float VelOscillationY { get; }
        float Limit { get; }
        float VelChange { get; }
    }
}
