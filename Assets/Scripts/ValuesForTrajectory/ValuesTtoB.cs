namespace Assets.Scripts.ValuesForTrajectory
{
    public class ValuesTtoB : TrajectoryValues
    {
        public ValuesTtoB()
        {
            DirectionX = 0f;
            DirectionY = 1f;
            VelDesplX = 0f;
            VelDesplY = -0.05f;
            OscillationX = 1f;
            OscillationY = 0f;
            VelOscillationX = 5f;
            VelOscillationY = 0f;
            Limit = -0.1f;
        }
    }
}
