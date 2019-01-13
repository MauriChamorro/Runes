namespace Assets.Scripts.ValuesForTrajectory
{
    public class ValuesLtoR : TrajectoryValues
    {
        public ValuesLtoR()
        {
            DirectionX = 1f;
            DirectionY = 0f;
            VelDesplX = 0.05f;
            VelDesplY = 0f;
            OscillationX = 0f;
            OscillationY = 1f;
            VelOscillationX = 0f;
            VelOscillationY = 5f;
            Limit = 1.1f;
        }
    }
}
