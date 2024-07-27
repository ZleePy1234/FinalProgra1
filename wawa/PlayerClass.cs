namespace PlayerClass
{
    public class CreacionPlayer
    {
        public struct PlayerAttack
        {
            public string name;
            public int damage;
            public int block;

            public PlayerAttack(string name, int damage, int block)
            {
                this.name = name;
                this.damage = damage;
                this.block = block;
            }

        }
        public struct PlayerData
        {
            public string playerName;
            public int playerHP;
            public int playerPoints;

            public PlayerAttack playerAttack;
            
            public PlayerAttack playerSpell;

            public PlayerAttack playerBlock;

            public PlayerData(string playerName, int playerHP, int playerPoints, PlayerAttack playerAttack, PlayerAttack playerSpell, PlayerAttack playerBlock)
            {
                this.playerName = playerName;
                this.playerHP = playerHP;
                this.playerPoints = playerPoints;
                this.playerAttack = playerAttack;
                this.playerSpell = playerSpell;
                this.playerBlock = playerBlock;
            }
        }

        //declaracion de clases
        //clase warlock
        #region Warlock
        public static PlayerAttack Hacha = new PlayerAttack("Hacha de mano", 18,0);

        public static PlayerAttack EstallidoArcano = new PlayerAttack("Estallido arcano", 30, 0);
        public static PlayerAttack  Bloquear = new PlayerAttack("Escudo Magico", 0, 20);
        public static PlayerData WarlockData = new PlayerData("Warlock",150, 0, Hacha, EstallidoArcano, Bloquear); 

        #endregion
        #region Paladin
    }
}