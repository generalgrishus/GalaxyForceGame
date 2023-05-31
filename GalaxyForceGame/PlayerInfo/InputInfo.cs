using Microsoft.Xna.Framework.Input;


namespace GalaxyForceGame.PlayerInfo
{
    /// <summary>
    /// Класс необходим для возможности создания 2-х 
    /// и более игроков на одном ПК
    /// </summary>
    public class InputInfo
    {
        public Keys Left;
        public Keys Right;
        public Keys Up;
        public Keys Down;
        public Keys Attack;
        public Keys UseShield;
        public Keys Ultimate;
        public Keys Exit;

        public KeyboardState previousKey;
        public KeyboardState currentKey;
    }
}
