using System.Security.AccessControl;
using Enemigos;
using Loot;
using Cuartos;
using PlayerClass;

namespace EjercicioComentarios
{
    public class EjercicioComments
    {
        //aqui declararemos las variables necesarias para la ejecucion del juego y los aspectos y sistemas que tengamos
        


        static void Main(string[] args)
        {
            //Aqui llamaremos las demas acciones del juego, sin poner nada en el main mas que metodos
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
            //se llama GameplayLoop
        }

        static void GameplayLoop()
        {
            //aqui invocare el metodo que generara aleatoriamente el primer piso de la mazmorra

            //despues de llamar generacionPiso carga el menu de seleccion del jugador
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
            // esto va generar primero un numero aleatorio entre 5 y 8

            // despues de esto va generar cada cuarto aleatoriamente con los siguientes parametros pudiendo ser entre un si o un no
            // Primero generara si hay algun enemigo en el cuarto
            // de ser el caso escoge un enemigo aleatoriamente
            // despues de eso genera si hay algun tesoro o tipo de loot en el cuarto
        }
        
    }
}
