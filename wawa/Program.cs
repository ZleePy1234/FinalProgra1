﻿using static Enemigos.CreacionEnemigos;
using static Loot.CreacionLoot;
using static Cuartos.CreacionCuartos;
using static PlayerClass.CreacionPlayer;

namespace EjercicioComentarios
{
    public class EjercicioComments
    {
        //aqui declararemos las variables necesarias para la ejecucion del juego y los aspectos y sistemas que tengamos
        #region Vars RNG
        public static int rndCuarto;
        public static int rndEnemigo;
        public static int rndLoot;
        public static int numCuartos;

        public static bool noItem = false;
        public static bool noEnemy = false;

        public static string cuartoActual;
        public static LootData LootActual = new LootData("placeholder", 0, 0);

        public static EnemyAttackData EnemigoActualAtaque1 = new EnemyAttackData("placeholder", 0, 0, 0);
        public static EnemyAttackData EnemigoActualAtaque2 = new EnemyAttackData("placeholder", 0, 0, 0);
        public static EnemyAttackData EnemigoActualAtaque3 = new EnemyAttackData("placeholder", 0, 0, 0);
        public static EnemyAttackData EnemigoActualAtaqueSeleccionado = new EnemyAttackData("placeholder", 0, 0, 0);

        public static EnemyData EnemigoActual = new EnemyData("placeholder", 0, 0, 0,EnemigoActualAtaque1, EnemigoActualAtaque2, EnemigoActualAtaque3);
        #endregion


        static void Main(string[] args)
        {
            /* DEBUG PARA VER SI FUNCIONA SELECCION ALEATORIA
            Console.Clear();
            ListaEnemigosAtaques();
            //Aqui llamaremos las demas acciones del juego, sin poner nada en el main mas que metodos
            Random rnd = new Random();
            int enemigoSeleccionado = rnd.Next(0, 2);
            Console.WriteLine("El Numero Generado es "+ enemigoSeleccionado);
            Console.WriteLine("Corresponde al siguiente Enemigo");
            EnemyData CurrentEnemy = ListaEnemigos[enemigoSeleccionado];
            Console.WriteLine("Nombre " + CurrentEnemy.enemyName);
            Console.WriteLine("Vida " + CurrentEnemy.enemyHealth);
            Console.WriteLine("Puntos " + CurrentEnemy.enemyPoints);
            Console.WriteLine("ID " + CurrentEnemy.enemyID);
            Console.WriteLine("El enemigo tiene los siguientes Ataques");
            Console.WriteLine("");
            int ataqueSeleccionado = rnd.Next(0, 3);
            
            if(CurrentEnemy.enemyID == 0)
            {
                EnemyAttackData CurrentAttack = AtaquesEsqueleto[ataqueSeleccionado];
                for(int i = 0; i < AtaquesEsqueleto.Count; i++)
                {
                    Console.WriteLine("Nombre del Ataque " + AtaquesEsqueleto[i].attackName);
                    Console.WriteLine("Daño del ataque " + AtaquesEsqueleto[i].attackDamage);
                    Console.WriteLine("Bloqueo del Ataque " + AtaquesEsqueleto[i].attackBlock);
                    Console.WriteLine("ID del Ataque " + AtaquesEsqueleto[i].attackID);
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                Console.WriteLine("el ataque seleccionado aleatoriamente fue " + CurrentAttack.attackName);
                Console.WriteLine("Daño " + CurrentAttack.attackDamage);
                Console.WriteLine("Bloqueo "+ CurrentAttack.attackBlock);
                Console.WriteLine("ID " + CurrentAttack.attackID);


            }
            else if(CurrentEnemy.enemyID == 1)
            {
                EnemyAttackData CurrentAttack = AtaquesElemental[ataqueSeleccionado];
                for(int i = 0; i < AtaquesElemental.Count; i++)
                {
                    Console.WriteLine("Nombre del Ataque " + AtaquesElemental[i].attackName);
                    Console.WriteLine("Daño del ataque " + AtaquesElemental[i].attackDamage);
                    Console.WriteLine("Bloqueo del Ataque " + AtaquesElemental[i].attackBlock);
                    Console.WriteLine("ID del Ataque " + AtaquesElemental[i].attackID);
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                Console.WriteLine("el ataque seleccionado aleatoriamente fue " + CurrentAttack.attackName);
                Console.WriteLine("Daño " + CurrentAttack.attackDamage);
                Console.WriteLine("Bloqueo "+ CurrentAttack.attackBlock);
                Console.WriteLine("ID " + CurrentAttack.attackID);
            }
            Console.WriteLine("");

            Console.ReadKey();
            */

            

            
        }

        static void Start()
        {
            //Aqui llamaremos el menu principal del juego
            
            // este llamara un metodo con el menu
        }

        static void MenuPrincipal()
        {
             // aqui es  donde el jugador podra elegir que hacer, si jugar o salir de la aplicacion, si decide jugar sera llevado a la creacion de personaje
        }

        static void MenuSeleccionPersonaje()
        {
            //Aqui es donde el jugador escogera su clase y su nombre para su personaje, despues de esto se le preguntara si asi esta bien o si desea cambiar alguna
            //parte del personaje
            
            //despues de que confirme que todo esta bien, se pasara a asignar las stats de la clase que selecciono y empieza la partida
        }

        static void InicioPartida()
        {
            DeclaracionVariablesExploracion();

            //se llama GameplayLoop
        }

        static void GameplayLoop()
        {
            //aqui invocare el metodo que generara aleatoriamente el primer piso de la mazmorra

            //despues de llamar generacionPiso carga el menu de seleccion del jugador
        }

        static void DeclaracionVariablesExploracion()
        {
            ListaCuartos();
            ListaEnemigosAtaques();
            ListaLoot();
        }

        static void MenuSeleccionGameplay()
        {
            //aqui se llama el menu de seleccion del jugador donde se le dan las opciones siguientes
            // si hay un enemiogo le da la opcion de pelear
            //si hasy un tesoro le da la opcion de intentar abrir el cofre o buscar el tesoro
            // si no hay nada de lo siguiente le da la opcion de avanzar
            //si selecciona combate se llama su metodo respectivo
            //si selecciona tesoro llama el metodo del tesoro
            // si selecciona avanzar se mueve al siguiente cuarto y el medidor de antorcha se baja un punto
            //si su antorcha esta en 0 y intenta avanzar es un game over
            // si el siguiente cuarto es el cuarto del jefe, en vez de llamar el proximo cuarto llama la funcion de bossfight
        }

        static void Combate()
        {
            // Aqui se empieza el combate, primero se checa en que cuarto esta el jugador
            //despues de eso se checa que tipo de enemigo esta ahi y se cargan sus estadisticas
            // al hacer esto empieza el combate, el enemigo escogera una accion, y luego el jugador escogera una
            //despues de esto ambas acciones ocurriran, primero ocurriendo la del enemigo y despues la del jugador
            // se imprimira un poco de texto dando una pista de que clase de accion escogio el enemigo para ayudar un poco al jugador
            // esto se repetira hasta que los puntos de vida del enemigo o del jugador sean reducidos a 0
            //si el jugador gana, este puede elegir perder un nivel de antorcha por recuperar su vida al maximo
            // despues de esto se carga de regreso el cuarto y el jugador vuelve al menu de eleccion
        }

        static void Looteo()
        {
            // Aqui empieza la fase de looteo
            //el jugador debe escoger un numero aleatorio entre 1 y 10
            // el juego generara un numero aleatorio entre 1 y 10
            // dependiendo de que tan lejos o cerca este del numero escogido por la computadora, el jugador recibira loot acorde
            //mientras mas cerca mejor loot, como pociones de curacion o puntuacion extra
            //mientras mas lejos peor loot, como algo envenenado que lo haga perder vida cada turno
        }

        static void GeneracionPiso()
        {
            Random rndCantidadCuartos = new Random();
            numCuartos = rndCantidadCuartos.Next(5,9);
        }

        static void GeneracionCuartoActual()
        {
            noItem = false;
            noEnemy = false;
            Random rnd = new Random();
            rndCuarto = rnd.Next(0, 13);
            cuartoActual = CuartosList[rndCuarto];
            rndEnemigo = rnd.Next(0, 2);
            EnemigoActual.enemyName = ListaEnemigos[rndEnemigo].enemyName;
            EnemigoActual.enemyHealth = ListaEnemigos[rndEnemigo].enemyHealth;
            EnemigoActual.enemyID = ListaEnemigos[rndEnemigo].enemyID;
            EnemigoActual.Attack1 = ListaEnemigos[rndEnemigo].Attack1;
            EnemigoActual.Attack2 = ListaEnemigos[rndEnemigo].Attack2;
            EnemigoActual.Attack3 = ListaEnemigos[rndEnemigo].Attack3;
            rndLoot = rnd.Next(0, 6);
            LootActual.lootName = ItemsLoot[rndLoot].lootName;
            LootActual.lootValue = ItemsLoot[rndLoot].lootValue;
            LootActual.lootID = ItemsLoot[rndLoot].lootID;

            /*
            Console.WriteLine("noItem " + noItem);
            Console.WriteLine("noEnemy " + noEnemy);
            Console.WriteLine("Cuarto Actual " + cuartoActual);
            Console.WriteLine("");
            */
        }
    }
}
