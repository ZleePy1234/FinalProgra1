namespace PlayerClass
{
    public class CreacionPlayer
    {
        //struct para la creacion de ataques de las clases distintas
        public struct PlayerAttack
        {
            public string name;
            public int damage;
            public int block;

            public bool isRanged;

            public PlayerAttack(string name, int damage, int block, bool isRanged)
            {
                this.name = name;
                this.damage = damage;
                this.block = block;
                this.isRanged = isRanged;
            }

        }

        //struct para la creacion de las estadisticas de cada clase asi como de sus ataques
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
        public static PlayerAttack Hacha = new PlayerAttack("Hacha de mano", 18,0, false);

        public static PlayerAttack EstallidoArcano = new PlayerAttack("Estallido arcano", 30, 0, true);
        public static PlayerAttack  Bloquear = new PlayerAttack("Escudo Magico", 0, 25, false);
        public static PlayerData WarlockData = new PlayerData("Warlock",150, 0, Hacha, EstallidoArcano, Bloquear); 

        #endregion
        //clase paladin
        #region Paladin

        public static PlayerAttack Martillo = new PlayerAttack("Golpe de Martillo", 20, 0, false);
        public static PlayerAttack Fuerza = new PlayerAttack("Emanar Fuerza", 12, 20, true);
        public static PlayerAttack EscudoDivino = new PlayerAttack("Escudo Divino", 0, 50, false);
        public static PlayerData PaladinData  = new PlayerData("Paladin",200, 0,Martillo, Fuerza, EscudoDivino);

        #endregion

        //clase mago

        #region Mago

        public static PlayerAttack Bastonazo = new PlayerAttack("Bastonazo", 10,0, false);
        public static PlayerAttack BolaFuego = new PlayerAttack("Bola de Fuego", 35,0,true);
        public static PlayerAttack BarreraMagica = new PlayerAttack("Barrera Magica", 0,15, false);
        public static PlayerData MagoData = new PlayerData("Mago",125, 0,Bastonazo, BolaFuego, BarreraMagica);

        #endregion

        
    }
}