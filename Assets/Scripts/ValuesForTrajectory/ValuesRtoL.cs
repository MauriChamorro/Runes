namespace Assets.Scripts.ValuesForTrajectory
{
    public class ValuesRtoL : TrajectoryValues
    {
        public ValuesRtoL()
        {
            DirectionX = 1f;
            DirectionY = 0f;
            VelDesplX = -0.05f;
            VelDesplY = 0f;
            OscillationX = 0f;
            OscillationY = 1f;
            VelOscillationX = 0f;
            VelOscillationY = 5;
            Limit = -0.1f;
        }
    }
}
