using System.Diagnostics.Contracts;

namespace Enemigos
{
    public class CreacionEnemigos
    {
        //Estos dos structs son para declarar las variables de los enemigos
        //este se encarga de hacer un struct con los valores para el ataque, estos siendo el nombre, daño, si este ataque bloquea daño del jugador y cual es la id
        // la id sirve para poder llamar este ataque usando un random durante combate
        public struct EnemyAttackData
        {
            public string attackName;
            public int attackDamage;
            public int attackBlock;
            public int attackID;

            public EnemyAttackData(string attackName, int attackDamage, int attackBlock, int attackID)
            {
                this.attackName = attackName;
                this.attackDamage = attackDamage;
                this.attackBlock = attackBlock;
                this.attackID = attackID;
            }
        }
        //este struct se encarga de la data general del enemigo, esta viene siendo el nombre del enemigo, sus puntos de vida, los puntos que le otorga al jugador
        // y tambien sus ataques, cada enemigo tendra 2 ataques que puede hacer, el tercero siendo la accion de bloquear
        public struct EnemyData
        {
            public string enemyName;
            public int enemyHealth;
            public int enemyPoints;
            public EnemyAttackData Attack1;
            public EnemyAttackData Attack2;
            public EnemyAttackData Attack3;

            public EnemyData(string enemyName, int enemyHealth, int enemyPoints, EnemyAttackData Attack1, EnemyAttackData Attack2, EnemyAttackData Attack3)
            {
                this.enemyName = enemyName;
                this.enemyHealth = enemyHealth;
                this.enemyPoints = enemyPoints;
                this.Attack1 = Attack1;
                this.Attack2 = Attack2;
                this.Attack3 = Attack3;
            }   
        }

        //Aqui se crean los structs para los enemigos, tanto sus ataques como el enemigo en si
        #region DatosEsqueleto

        public static EnemyAttackData Bonk = new EnemyAttackData("Bonk", 20, 0, 1);
        public static EnemyAttackData Empujon = new EnemyAttackData("Empujon", 10, 0, 2);
        public static EnemyAttackData Bloquear = new EnemyAttackData("Bloquear",0, 20, 2);
        public static EnemyData Esqueleto = new EnemyData("Esqueleto", 50, 100, Bonk,Empujon,Bloquear );

        #endregion

        #region DatosElemental
        public static EnemyAttackData ProyectilAire = new EnemyAttackData("Proyectil de Aire",25, 0, 1);
        public static EnemyAttackData ProyectilRoca = new EnemyAttackData("Lanzamiento de Roca",25, 0, 2);
        public static EnemyAttackData FormaVapor = new EnemyAttackData("Forma de Vapor",0, 20, 3);
    }
}