#pragma warning disable CA1416 // Validate platform compatibility
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using static Enemigos.CreacionEnemigos;
using static Loot.CreacionLoot;
using static Cuartos.CreacionCuartos;
using static PlayerClass.CreacionPlayer;
using static Art.ArtASCII;
using System.Media;
using NAudio.Wave;


namespace EjercicioComentarios
{
    public class EjercicioComments
    {
        public static SoundPlayer battleMusic = new SoundPlayer();
        public static SoundPlayer gameplayMenuMusic = new SoundPlayer();
        public static SoundPlayer bossMusic = new SoundPlayer();


        public static string asciiEnemy;

        //aqui declararemos las variables necesarias para la ejecucion del juego y los aspectos y sistemas que tengamos
        #region Vars RNG
        public static int rndCuarto;
        public static int rndEnemigo;
        public static int rndLoot;
        public static int numCuartos;

        public static int rndInt;

        public static bool noItem = false;
        public static bool noEnemy = false;

        public static string cuartoActual = "placeholder";
        public static LootData LootActual = new LootData("placeholder", 0, 0);

        public static EnemyAttackData EnemigoActualAtaque1 = new EnemyAttackData("placeholder", 0, 0, 0);
        public static EnemyAttackData EnemigoActualAtaque2 = new EnemyAttackData("placeholder", 0, 0, 0);
        public static EnemyAttackData EnemigoActualAtaque3 = new EnemyAttackData("placeholder", 0, 0, 0);
        public static EnemyAttackData chosenEnemyAttack = new EnemyAttackData("placeholder", 0, 0, 0);
        public static EnemyAttackData EnemigoActualAtaqueSeleccionado = new EnemyAttackData("placeholder", 0, 0, 0);

        public static EnemyData EnemigoActual = new EnemyData("placeholder", 0, 0, 0,EnemigoActualAtaque1, EnemigoActualAtaque2, EnemigoActualAtaque3);
        #endregion
        #region Vars Player
        public static int seleccionPlayerClass;

        static PlayerAttack playerAttack1 = new PlayerAttack("placeholder", 0,0,false);
        static PlayerAttack playerAttack2 = new PlayerAttack("placeholder", 0,0,false);
        static PlayerAttack playerAttack3 = new PlayerAttack("placeholder", 0,0,false);
        static PlayerAttack chosenPlayerAttack = new PlayerAttack("placeholder", 0,0,false);
        static PlayerData DatosJugador = new PlayerData("placeholder", 0, 0, playerAttack1, playerAttack2, playerAttack3);

        #endregion

        #region  Inv

        public static List<LootData> ItemInventory = new List<LootData>();
        public static bool isRoomLooted = false;
        public static bool isRoomEnemyDefeated = false;

        public static int selectmenu;

        #endregion

        static void PlayBattleMusic()
        {

            battleMusic.SoundLocation = @"C:\Users\Eslepo\Desktop\FinalProgra1\wawa\BattleMusicUncut.wav";
            bossMusic.SoundLocation = @"C:\Users\Eslepo\Desktop\FinalProgra1\wawa\BossBattleMusic.wav";
            gameplayMenuMusic.SoundLocation = @"C:\Users\Eslepo\Desktop\FinalProgra1\wawa\GameplayMusic.wav";
        }

        static void Main(string[] args)
        {
            PlayBattleMusic();
            Console.Clear();
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
            MenuPrincipal();
            

            
        }

        static void Start()
        {
            //Aqui llamaremos el menu principal del juego
            
            // este llamara un metodo con el menu
        }

        static void MenuPrincipal()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@$" .--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--. 
/ .. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \
\ \/\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ \/ /
 \/ /`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'\/ / 
 / /\                                                                                / /\ 
/ /\ \    ______    __    __    __      _   _____    _____  ____      __      _     / /\ \
\ \/ /   (_  __ \   ) )  ( (   /  \    / ) / ___ \  / ___/ / __ \    /  \    / )    \ \/ /
 \/ /      ) ) \ \ ( (    ) ) / /\ \  / / / /   \_)( (__  / /  \ \  / /\ \  / /      \/ / 
 / /\     ( (   ) ) ) )  ( (  ) ) ) ) ) )( (  ____  ) __)( ()  () ) ) ) ) ) ) )      / /\ 
/ /\ \     ) )  ) )( (    ) )( ( ( ( ( ( ( ( (__  )( (   ( ()  () )( ( ( ( ( (      / /\ \
\ \/ /    / /__/ /  ) \__/ ( / /  \ \/ /  \ \__/ /  \ \___\ \__/ / / /  \ \/ /      \ \/ /
 \/ /    (______/   \______/(_/    \__/    \____/    \____\\____/ (_/    \__/        \/ / 
 / /\     _____       ____      ____  ________  _____ ______    _____ _______        / /\ 
/ /\ \   (_   _)     / __ \    / __ \(___  ___)/ ___/(   __ \  / ____\\     /       / /\ \
\ \/ /     | |      / /  \ \  / /  \ \   ) )  ( (__   ) (__) )( (___   \   /        \ \/ /
 \/ /      | |     ( ()  () )( ()  () ) ( (    ) __) (    __/  \___ \   ) (          \/ / 
 / /\      | |   __( ()  () )( ()  () )  ) )  ( (     ) \ \  _     ) )  \_/          / /\ 
/ /\ \   __| |___) )\ \__/ /  \ \__/ /  ( (    \ \___( ( \ \_))___/ /    _          / /\ \
\ \/ /   \________/  \____/    \____/   /__\    \____\)_) \__//____/    (_)         \ \/ /
 \/ /                                                                                \/ / 
 / /\.--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--..--./ /\ 
/ /\ \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \.. \/\ \
\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `'\ `' /
 `--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--'`--' ");
            MenuSeleccionPersonaje();
             // aqui es  donde el jugador podra elegir que hacer, si jugar o salir de la aplicacion, si decide jugar sera llevado a la creacion de personaje
        }

        static void MenuSeleccionPersonaje()

        {
            //Aqui es donde el jugador escogera su clase y su nombre para su personaje, despues de esto se le preguntara si asi esta bien o si desea cambiar alguna
            //parte del personaje
            Console.WriteLine("Dungeon Looters! (super pre alpha)");
            Console.WriteLine("picale a lo q sea pa empezar");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
            Console.Clear();
            //despues de que confirme que todo esta bien, se pasara a asignar las stats de la clase que selecciono y empieza la partida
            Console.WriteLine(@"                                                                                         
                                       █     ░▓                      ▒████▓              
                                       █   ███▒     ▓▓         ▓██████▒  ▒██████▓░       
                 ▓▓████▓▒                ▓█████▓    ▓▓        ██▒   ░▓████▓░   ▒██       
              ▒█▓   ░░░  ▒▓▓            ▒█████████            ██▒ █████  █████░░██       
             ██  ▓█▓██▒▓█▓  ▒█░         ▒██▒  ▓███▒   ░       ▓██ ██        ██ ▒█▓       
       ░█░  ░█░ ░█▒  ██  ▓█    ▓▓        ██▒   ██▓    ▓        ██ ▒████░ ████▓ ██░       
          ▓▓  ▓█▓█████  ▓█                ░████▓               ▓██ ▓███  ████ ▓█▓        
            ▒█▓░     ░▓█▒            █▓░         ▒██████░       ███ ▒██▒░██▓ ▓██         
                ▒▓▓▓▓▒                 ███░ ▓███████████████     ▒██▒ ▒██▓ ░██▓          
                                         ███████████████████       ▓███░░████            
                                           ▓████████████████          ▓██▓               
                                              ░░                                         ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("             1.- Warlock");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("                   2.- Mago.               ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("3.Paladin");
            Console.WriteLine("");
            string textoplayer;
            textoplayer = Console.ReadLine();

            seleccionPlayerClass  = Convert.ToInt32(textoplayer);
            if (seleccionPlayerClass == 1)
            {  
                DatosJugador.playerName = WarlockData.playerName;
                DatosJugador.playerHP = WarlockData.playerHP;
                DatosJugador.playerPoints = WarlockData.playerPoints;
                DatosJugador.playerAttack = WarlockData.playerAttack;
                DatosJugador.playerSpell = WarlockData.playerSpell;
                DatosJugador.playerBlock = WarlockData.playerBlock;
            }
            else if (seleccionPlayerClass == 2)
            {
                DatosJugador.playerName = MagoData.playerName;
                DatosJugador.playerHP = MagoData.playerHP;
                DatosJugador.playerPoints = MagoData.playerPoints;
                DatosJugador.playerAttack = MagoData.playerAttack;
                DatosJugador.playerSpell = MagoData.playerSpell;
                DatosJugador.playerBlock = MagoData.playerBlock;
            }
            else if(seleccionPlayerClass == 3)
            {
                DatosJugador.playerName = PaladinData.playerName;
                DatosJugador.playerHP = PaladinData.playerHP;
                DatosJugador.playerPoints = PaladinData.playerPoints;
                DatosJugador.playerAttack = PaladinData.playerAttack;
                DatosJugador.playerSpell = PaladinData.playerSpell;
                DatosJugador.playerBlock = PaladinData.playerBlock;
            }
            else
            {
                Console.WriteLine("Seleccion no valida, escogiendo una clase por defecto");
                DatosJugador.playerName = WarlockData.playerName;
                DatosJugador.playerHP = WarlockData.playerHP;
                DatosJugador.playerPoints = WarlockData.playerPoints;
                DatosJugador.playerAttack = WarlockData.playerAttack;
                DatosJugador.playerSpell = WarlockData.playerSpell;
                DatosJugador.playerBlock = WarlockData.playerBlock;
            }
            InicioPartida();
        }

        static void InicioPartida()
        {
            Console.Clear();
            DeclaracionVariablesExploracion();
            GameplayLoop();


            //se llama GameplayLoop
        }

        static void GameplayLoop()
        {
            //aqui invocare el metodo que generara aleatoriamente el primer piso de la mazmorra

            //despues de llamar generacionPiso carga el menu de seleccion del jugador
            GeneracionCuartoActual();
            MenuSeleccionGameplay();
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
            Console.WriteLine(@$"{DatosJugador.playerName}, al avanzar has llegado a {cuartoActual}");
            if (noItem == true)
            {
                if (noEnemy == true)
                {
                    Console.WriteLine("Encuentras el cuarto totalmente vacio.... Sin nadie ni nada de importancia.");
                }
                else if (noEnemy == false)
                {
                    Console.WriteLine($"Encuentras el cuarto sin nada de valor, pero encuentras un {EnemigoActual.enemyName}");
                }
            }
            else if (noItem == false)
            {
                if(noEnemy == false)
                {
                    Console.WriteLine($"Encuentras algo que podrias lootear, es {LootActual.lootName}");
                    Console.WriteLine($"Pero no es todo lo que vez, tambien vez en el cuarto un {EnemigoActual.enemyName}");
                }
                else if (noEnemy == true)
                {
                    Console.WriteLine($"No vez señales de nadie mas en el cuarto, y encuentras {LootActual.lootName}");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Que decides hacer?");
            Console.WriteLine($"1.- Atacar al {EnemigoActual.enemyName}");
            Console.WriteLine($"2.- Lootear {LootActual.lootName}");
            Console.WriteLine("3.-Avanzar al siguiente cuarto");
            selectmenu = Convert.ToInt32(Console.ReadLine());
            switch (selectmenu)
            {
                case 1:
                    Combate();
                    break;
                case 2:
                    Looteo();
                    break;
                case 3:
                    NextRoom();
                    break;
                default:
                    Console.WriteLine("Escoge algo valido");
                    break;
            }
            Console.ReadKey();
            Combate();
        }

        static void Combate()
        {
            Console.Clear();
            bool isFighting = true;
            battleMusic.PlayLooping();

            Random rndEnemyAttack = new Random();
            do
            {Console.Clear();
                Console.WriteLine(@$"Te enfrentas a un {EnemigoActual.enemyName} , Que haces?");
                Console.WriteLine("");
                Console.WriteLine(@$"1.- {DatosJugador.playerAttack.name}");
                Console.WriteLine(@$"2.- {DatosJugador.playerSpell.name}");
                Console.WriteLine(@$"3.- {DatosJugador.playerBlock.name}");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(@$"HP Player: {DatosJugador.playerHP} ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(@$"|| ");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(@$"HP enemigo: {EnemigoActual.enemyHealth}");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
                int attackSelect;
                attackSelect = Convert.ToInt32(Console.ReadLine());
                #region Asignacion Vars Ataque Player
                if(attackSelect == 1)
                {
                    chosenPlayerAttack.name = DatosJugador.playerAttack.name;
                    chosenPlayerAttack.damage = DatosJugador.playerAttack.damage;
                    chosenPlayerAttack.block = DatosJugador.playerAttack.block;
                    chosenPlayerAttack.isRanged = DatosJugador.playerAttack.isRanged;
                }
                else if (attackSelect == 2)
                {
                    chosenPlayerAttack.name = DatosJugador.playerSpell.name;
                    chosenPlayerAttack.damage = DatosJugador.playerSpell.damage;
                    chosenPlayerAttack.block = DatosJugador.playerSpell.block;
                    chosenPlayerAttack.isRanged = DatosJugador.playerSpell.isRanged;
                }
                else
                {
                    chosenPlayerAttack.name = DatosJugador.playerBlock.name;
                    chosenPlayerAttack.damage = DatosJugador.playerBlock.damage;
                    chosenPlayerAttack.block = DatosJugador.playerBlock.block;
                    chosenPlayerAttack.isRanged = DatosJugador.playerBlock.isRanged;
                }
                #endregion

                #region Asignacion Vars Ataque Enemigo
                int enemySelect = rndEnemyAttack.Next(0, 3);
                if(enemySelect == 0)
                {
                    chosenEnemyAttack.attackName = EnemigoActual.Attack1.attackName;
                    chosenEnemyAttack.attackDamage = EnemigoActual.Attack1.attackDamage;
                    chosenEnemyAttack.attackBlock = EnemigoActual.Attack1.attackBlock;
                    chosenEnemyAttack.attackID = EnemigoActual.Attack1.attackID;
                }
                else if(enemySelect == 1)
                {
                    chosenEnemyAttack.attackName = EnemigoActual.Attack2.attackName;
                    chosenEnemyAttack.attackDamage = EnemigoActual.Attack2.attackDamage;
                    chosenEnemyAttack.attackBlock = EnemigoActual.Attack2.attackBlock;
                    chosenEnemyAttack.attackID = EnemigoActual.Attack2.attackID;
                }
                else
                {
                    chosenEnemyAttack.attackName = EnemigoActual.Attack3.attackName;
                    chosenEnemyAttack.attackDamage = EnemigoActual.Attack3.attackDamage;
                    chosenEnemyAttack.attackBlock = EnemigoActual.Attack3.attackBlock;
                    chosenEnemyAttack.attackID = EnemigoActual.Attack3.attackID;
                }


                #endregion

                Console.WriteLine(@$"El enemigo utilizo {chosenEnemyAttack.attackName}, haciendo {chosenEnemyAttack.attackDamage} puntos de daño!");
                int enemyattackdamage = chosenEnemyAttack.attackDamage;
                enemyattackdamage -= chosenPlayerAttack.block;
                if (enemyattackdamage < 0)
                {
                    enemyattackdamage = 0;
                }
                else{}
                if(enemyattackdamage != chosenEnemyAttack.attackDamage )
                {
                    Console.WriteLine(@$"Tu accion selccionada bloqueo una parte del daño, ahora solo recibes {enemyattackdamage}");
                }else
                {}
                Console.WriteLine(@"");
                Console.WriteLine(@$"El Jugador uso {chosenPlayerAttack.name}, haciendo {chosenPlayerAttack.damage} puntos de daño!");
                int playerattackdamage = chosenPlayerAttack.damage;
                playerattackdamage -= chosenEnemyAttack.attackBlock;
                if (playerattackdamage < 0)
                {
                    playerattackdamage = 0;
                }
                else{}
                if(playerattackdamage != chosenPlayerAttack.damage)
                {
                    Console.WriteLine(@$"El enemigo bloqueo tu ataque!, el daño de tu ataque fue reducido  a {playerattackdamage}");
                }
                else{}
                DatosJugador.playerHP -= enemyattackdamage;
                Thread.Sleep(2250);
                if(playerattackdamage > 0)
                {
                    if(EnemigoActual.enemyID == 0)
                    {
                        ASCIIesqueleto();
                    }
                    else if (EnemigoActual.enemyID == 1)
                    {
                        ASCIIelemental();
                    }
                }
                else{}
                if(DatosJugador.playerHP <= 0)
                {
                    Console.WriteLine("Fuiste Vencido!");
                }
                else
                {
                    EnemigoActual.enemyHealth -= playerattackdamage;
                }
                if(DatosJugador.playerHP <= 0)
                {
                    isFighting = false;
                }
                else if (EnemigoActual.enemyHealth <= 0)
                {
                    isFighting = false;
                }
                else {}

                


                
            }while(isFighting == true);

            if(DatosJugador.playerHP <= 0)
            {
                Console.WriteLine($"Fuiste Vencido por el {EnemigoActual.enemyName}");
            }
            else
            {
                if(EnemigoActual.enemyID == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    EsqueletoDeath();
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (EnemigoActual.enemyID == 1)
                {

                }
            }
            Console.ReadKey();
            battleMusic.Stop();


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
            ItemInventory.Add(LootActual);
            Console.WriteLine(@$"Recoges {LootActual.lootName}, estimas que posiblemente valga unos {LootActual.lootValue}");
        }

        static void GeneracionPiso()
        {

        }
        static void NextRoom()
        {
            Console.Clear();
            Console.WriteLine(@"");
        }
        static void GeneracionCuartoActual()
        {
            noItem = false;
            noEnemy = false;
            Random rnd = new Random();
            rndCuarto = rnd.Next(0, 13);
            cuartoActual = CuartosList[rndCuarto];
            rndInt = rnd.Next(0, 2);
            //DEBUG PARA TENER ESQUELETO
            rndInt = 1;
            if (rndInt == 0)
            {
                noEnemy = true;
            }
            else if (rndInt == 1)   
            {
                noEnemy = false;
                rndEnemigo = rnd.Next(0, 2);
                //debug para esqueleto
                rndEnemigo = 0;
                EnemigoActual.enemyName = ListaEnemigos[rndEnemigo].enemyName;
                EnemigoActual.enemyHealth = ListaEnemigos[rndEnemigo].enemyHealth;
                EnemigoActual.enemyID = ListaEnemigos[rndEnemigo].enemyID;
                EnemigoActual.Attack1 = ListaEnemigos[rndEnemigo].Attack1;
                EnemigoActual.Attack2 = ListaEnemigos[rndEnemigo].Attack2;
                EnemigoActual.Attack3 = ListaEnemigos[rndEnemigo].Attack3;
            }
            rndInt = rnd.Next(0, 2);
            if(rndInt == 0)
            {
                noItem = true;
            }
            else if(rndInt == 1)
            {
                noItem = false;
                rndLoot = rnd.Next(0, 6);
                LootActual.lootName = ItemsLoot[rndLoot].lootName;
                LootActual.lootValue = ItemsLoot[rndLoot].lootValue;
                LootActual.lootID = ItemsLoot[rndLoot].lootID;
            }

            /*
            Console.WriteLine("noItem " + noItem);
            Console.WriteLine("noEnemy " + noEnemy);
            Console.WriteLine("Cuarto Actual " + cuartoActual);
            Console.WriteLine("");
            */
        }
    }
}
#pragma warning restore CA1416 // Validate platform compatibility
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.