using System.Diagnostics.Contracts;
using System.Security.AccessControl;

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
            public int enemyID;
            public EnemyAttackData Attack1;
            public EnemyAttackData Attack2;
            public EnemyAttackData Attack3;

            public EnemyData(string enemyName, int enemyHealth, int enemyPoints, int enemyID, EnemyAttackData Attack1, EnemyAttackData Attack2, EnemyAttackData Attack3)
            {
                this.enemyName = enemyName;
                this.enemyHealth = enemyHealth;
                this.enemyPoints = enemyPoints;
                this.enemyID = enemyID;
                this.Attack1 = Attack1;
                this.Attack2 = Attack2;
                this.Attack3 = Attack3;
            }   
        }

        //Aqui se crean los structs para los enemigos, tanto sus ataques como el enemigo en si
        #region DatosEsqueleto

        public static EnemyAttackData Bonk = new EnemyAttackData("Bonk", 10, 0, 1);
        public static EnemyAttackData Empujon = new EnemyAttackData("Empujon", 5, 0, 2);
        public static EnemyAttackData Bloquear = new EnemyAttackData("Bloquear",0, 20, 3);
        public static EnemyData Esqueleto = new EnemyData("Esqueleto", 50, 100, 0,Bonk,Empujon,Bloquear );

        #endregion

        #region DatosElemental
        public static EnemyAttackData ProyectilAire = new EnemyAttackData("Proyectil de Aire",12, 0, 1);
        public static EnemyAttackData ProyectilRoca = new EnemyAttackData("Lanzamiento de Roca",26, 0, 2);
        public static EnemyAttackData FormaVapor = new EnemyAttackData("Forma de Vapor",0, 20, 3);
        public static EnemyData Elemental = new EnemyData("Elemental",75, 250, 1, ProyectilAire, ProyectilRoca, FormaVapor);

        #endregion

        #region DatosArmaduraReanimada JEFE

        public static EnemyAttackData GolpeEspada = new EnemyAttackData("Corte",18, 0, 1);
        public static EnemyAttackData Eviscerar = new EnemyAttackData("Eviscerar",35, 0, 2);
        public static EnemyAttackData Escudo = new EnemyAttackData("Alzar Escudo",0, 35, 3);

        public static EnemyData ArmaduraReanimada = new EnemyData("Armadura Reanimada",250, 1000, 1, GolpeEspada, Eviscerar, Escudo);
        #endregion

        #region DatosAboleth JEFE

        public static EnemyAttackData Mordida = new EnemyAttackData("Mordida",16, 0, 1);
        public static EnemyAttackData Acido = new EnemyAttackData("Drenado Psiquico",38, 0, 2);
        public static EnemyAttackData Moco = new EnemyAttackData("Moco Protectivo", 0, 33, 0);

        public static EnemyData Aboleth = new EnemyData("Aboleth",325, 1350, 2, Mordida, Acido, Moco);
        #endregion
        
        //Listas donde guardamos los enemigos, y listas con los ataques de cada uno
        #region ListasEnemigos
        public static List<EnemyData> ListaEnemigos = new List<EnemyData>();
        public static List<EnemyAttackData> AtaquesEsqueleto = new List<EnemyAttackData>();
        public static List<EnemyAttackData> AtaquesElemental = new List<EnemyAttackData>();
        #endregion

        //Listas donde guardamos los Jefes y listas con los ataques de ellos
        #region ListasJefes
        public static List<EnemyData> ListaJefes = new List<EnemyData>();
        public static List<EnemyAttackData> AtaquesArmadura = new List<EnemyAttackData>();
        public static List<EnemyAttackData> AtaquesAboleth = new List<EnemyAttackData>();

        #endregion
        public static void ListaEnemigosAtaques()
        {
            //Aqui agregamos a las listas los enemigos y los ataques
            ListaEnemigos.Add(Esqueleto);
            AtaquesEsqueleto.Add(Bonk);
            AtaquesEsqueleto.Add(Empujon);
            AtaquesEsqueleto.Add(Bloquear);

            ListaEnemigos.Add(Elemental);
            AtaquesElemental.Add(ProyectilAire);
            AtaquesElemental.Add(ProyectilRoca);
            AtaquesElemental.Add(FormaVapor);

            //Aqui agrgamos a las listas los jefes y los ataques

            ListaJefes.Add(ArmaduraReanimada);
            AtaquesArmadura.Add(GolpeEspada);
            AtaquesArmadura.Add(Eviscerar);
            AtaquesArmadura.Add(Escudo);

            ListaJefes.Add(Aboleth);
            AtaquesAboleth.Add(Mordida);
            AtaquesAboleth.Add(Acido);
            AtaquesAboleth.Add(Moco);
        }
    }
}