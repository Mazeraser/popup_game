namespace Assets.Codebase.Mechanics.Timer
{
    public interface ITimer
    {
        void RaiseTime(float time);
        void ResetTimer();
        bool SetActiveTimer { set; }
        bool IsGone { get; }
        float MaxTime { get; }
    }
}
    