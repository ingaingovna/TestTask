namespace Analytics
{
    public class LevelData
    {
        public int LevelNumber { get; set; }
        public string LevelName { get; set; }
        public int LevelCount { get; set; }
        public int LevelLoop { get; set; }
        public LevelType LevelType { get; set; }
        public FinishResult Result { get; set; }
        public float Time { get; set; }
        public int Progress { get; set; }
    }

    public enum LevelType
    {
        Default = 0,
        Boss = 1
    }

    public enum FinishResult
    {
        Win = 0,
        Lose = 1,
        Leave = 2
    }
}
