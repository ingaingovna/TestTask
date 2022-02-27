namespace Analytics
{
    public interface IAnalyticsService
    {
        void SendLevelStart(LevelData levelData);
        void SendLevelFinish(LevelData levelData);
    }
}