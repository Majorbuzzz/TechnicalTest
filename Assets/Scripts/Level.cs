namespace Assets.Scripts
{
    static class Level
    {
        public static char[][,] Levels => new[] {level_1, level_2};

        public static readonly char[,] level_1 = {
            { '0', '0', '0', '0', 'e' },
            { '0', '1', '1', '1', 'd' },
            { '0', '1', '0', 'k', '0' },
            { '0', '1', '0', '0', '0' },
            { 's', '1', '0', '0', '0' }
        };

        public static readonly char[,] level_2 = {
            { '0', '0', '0', '0', '0' },
            { 's', '1', '0', '1', 'e' },
            { '0', '1', '0', '1', '0' },
            { 'k', '1', '0', '1', '0' },
            { '0', '1', 'd', '1', '0' }
        };
    }
}
