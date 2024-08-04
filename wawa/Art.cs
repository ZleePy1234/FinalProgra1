using System.Media;
using NAudio.Wave;



namespace Art
{
    public class ArtASCII
    {
        public static WaveStream mainOutputStream = new WaveFileReader(@"C:\Users\Eslepo\Desktop\FinalProgra1\wawa\hitEffect.wav");
        public static WaveChannel32 volumeStream = new WaveChannel32(mainOutputStream);
    
        public static WaveOutEvent sfxPlayer = new WaveOutEvent();
        
        
        public static void ASCIIesqueleto()
        {
            WaveStream mainOutputStream = new WaveFileReader(@"C:\Users\Eslepo\Desktop\FinalProgra1\wawa\hitEffect.wav");
            WaveChannel32 volumeStream = new WaveChannel32(mainOutputStream);
    
            WaveOutEvent sfxPlayer = new WaveOutEvent();
            sfxPlayer.Init(volumeStream);
            Console.Clear();
#pragma warning disable CA1416 // Validate platform compatibility
            SoundPlayer hitEffect = new SoundPlayer(@"C:\Users\Eslepo\Desktop\FinalProgra1\wawa\hitEffect.wav");
#pragma warning restore CA1416 // Validate platform compatibility
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"                                         
                      ▓███▓              
                     ▒█▓▒ ▓░             
                    ░██▒▒█▓              
                      ██▓▒███  █         
                      ███░▓██████ ██     
                     ▓   ░▒▓▓█▓ ▓▒       
                    █    ▒    ▒▓░██      
           ███████░█▒  ███▒██▒▓█▓███     
          ██     ██▓  ░█ ░███▓  ▓ ████   
         ░█▓              ▒   ███   ██   
                               █         
                         ░███▓██░        
                         ▒█████░▓        
                          ░▒             
                        ▓█▓█▒ ██░        
                        ▓  ▒███▒         
                       ▒███              
                     ░██                 
                  ████▒                  
                 ▓██  ▒                  
                ██▓  ▓░                  
               ▓▓    █                   
              ▒▓▒  ▒██▒                  
             ▓▓▒     ███                 
            █▓░        ███               
           █▒            ▒█▓             
         ░█▒               ░██           
        ██                    █▒         
       ▒███▒                ████         
     ███░               ░███░            
  ░███▓                                  
                                         ");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine(@"                                         
                      ▓███▓              
                     ▒█▓▒ ▓░             
                    ▒██▒▒█▓       █████  
                      ██▓▒███  ████████  
                      ███░▓██▒██████     
                     ▓   ░▒▓░█████       
                    █    ▒   ▒██▓░▒      
           ███████░▓▒  ███▒██  ░░▓██     
          ██     ██▓  ░█ ░███▓  ▓ ████   
         ░█▓              ▒   ███   ██   
                               █         
                         ░███▓██░        
                         ▒█████ ▓        
                          ░▓             
                        ▓█▓█▒ ██░        
                        ▓  ▒███▒         
                       ▒███              
                     ░██                 
                  ████▒                  
                 ▓██  ▒                  
                ██▓  ▓░                  
               ▓▓    █                   
              ▒▓▒  ▒██▒                  
             ▓▓▒     ███                 
            █▓░        ███               
           █▒            ▒█▓             
         ░█▒                ██           
        ██                    █▒         
       ▒███▒                ████         
     ███▒                ███░            
  ░███▓                                  
                                         ");
            Thread.Sleep(200);
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(@"                                         
                      ▓███▓              
                     ▒█▓▒ ▓░     ██      
                    ▒██▒▒█▓    ███████   
                      ██▓▒▓█▒███████     
                      ███░░██████ ▓      
                     ▓    ░████▒         
                    █    ░█████  ██      
           ███████░▓▒  ▓▒█████▒▓▓███     
          ██     ██▓    █████░  ▓ ████   
         ░█▓            ████░ ▓██   ██   
                       █████   █         
                      ██████▒▒██░        
                      █████▒▓██ ▓        
                      ████               
                        ░░ █▒ ██░        
                           ▒███▒         
                       ▒███              
                     ░██                 
                  ████▒                  
                 ▓██  ▒                  
                ██▓  ▓░                  
               ▓▓    █                   
              ▒▓▒  ▒██▒                  
             ▓▓▒     ███                 
            █▓░        ███               
           █▒            ▒█▓             
         ░█▒                ██           
        ██                    █▒         
       ▒███▒                ████         
     ███▒                ███░            
  ░███▓                                  
                                         ");
                sfxPlayer.Play();

                Thread.Sleep(200);
                
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.DarkGray;
                Console.WriteLine(@"                                         
                      ▓███▓              
                     ▒█▓▒ ▓░             
                    ▒██▒▒█▓              
                      ██▓▒███  █         
                      ███░▓██████ ██     
                     ▓   ░▒▓▓█▓ ▓▒       
                    █    ░    ▒▓░██      
           ███████░▓▒  ▓░  ██░▓█▓███     
          ██     ██▓    ██████  ▓ ████   
         ░█▓           █████  ▓██   ██   
                      ▓████    █         
                      █████▒█▓██░        
                      ████▒ ███ ▓        
                      ████ ░             
                      ████ █▒ ██░        
                      ███  ▒███▒         
                         ▓█              
                     ░██                 
                  ████▒                  
                 ▓██  ▒                  
                ██▓  ▓░                  
               ▓▓    █                   
              ▒▓▒  ▒██▒                  
             ▓▓▒     ███                 
            █▓░        ███               
           █▒            ▒█▓             
         ░█▒                ██           
        ██                    █▒         
       ▒███▒                ████         
     ███▒                ███░            
  ░███▓                                  
                                         ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine(@"                                         
                      ▓███▓              
                     ▒█▓▒ ▓░             
                    ░██▒▒█▓              
                      ██▓▒███  █         
                      ███░▓██████ ██     
                     ▓   ░▒▓▓█▓ ▓▒       
                    █    ▒    ▒▓░██      
           ███████░█▒  ███▒██▒▓█▓███     
          ██     ██▓  ░█ ░███▓  ▓ ████   
         ░█▓              ▒   ███   ██   
                               █         
                         ░███▓██░        
                         ▒█████░▓        
                          ░▒             
                        ▓█▓█▒ ██░        
                        ▓  ▒███▒         
                       ▒███              
                     ░██                 
                  ████▒                  
                 ▓██  ▒                  
                ██▓  ▓░                  
               ▓▓    █                   
              ▒▓▒  ▒██▒                  
             ▓▓▒     ███                 
            █▓░        ███               
           █▒            ▒█▓             
         ░█▒               ░██           
        ██                    █▒         
       ▒███▒                ████         
     ███░               ░███░            
  ░███▓                                  
                                         ");

   Console.ForegroundColor = ConsoleColor.White;
   sfxPlayer.Dispose();
        }

        public static void EsqueletoDeath()
        {
            Console.WriteLine(@"                                 ░██████           ░
                                 ░██████           ░
                                  ▒████▓           ░
                               ░░░▓████░░░         ░
                              ░▓██████████░        ░
                             ░▓████████████░        
                             ░█████████▓██▓         
                             ░████████████▒         
                              ░█▓░▓████▓██▒         
                              ░█████▒▒██▓█▓         
                              ░████████▒░▓░         
                               ▒████▓██░▒▒          
                            ░▓███▒███████▒          
                            ░██▓█▓▒░▓████▒░         
                            ░█▒     ░░▓██▓░         
                            ░█       ▒█░▓▓          
                            ▒█         ░▓▓          
                           ░▓█          ▒█░         
                           ░██          ▒█▓         
                          ░▓██▒        ░███░        
                          ░▒▓░          ░▓█░        
                          ░▓▓░          ░▓█░        
                          ░▓▒░           ▒█░        
                          ▒█▒            ▒█░       ░
                        ░▓█▓░            ▒█▓       ░
                       ░██▓░             ░██░      ░
                                           ██▓░    ░
░░░░░░░░░                                  ░▓██░░░░░");
            Console.WriteLine("Venciste al esqueleto");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(@"                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                  ░▒██▓░           ░
                                  ▓█████░          ░
                               ░▒░▒█████░          ░
                              ░███▓██████▓░        ░
                              ▓███████████▒        ░
                              ▒██▓████████▓        ░
                              ▒█████████░░▓▒       ░
                               █▓▒█▓▒█▓░░ ░█░      ░
                             ▒█████▓▓▓██▓░ ░█░     ░
                             ░██▓▒░   ░█▒   ██░    ░
                             ░▓█▓      ▓▓░  ▒▓░    ░
                             ░▓▒█░     ▒▓░ ░█▒░    ░
                             ░█░▒▓░    ░█▒ ▓▓░     ░
                             ▒█░░▓█░   ▒██▓█▒      ░
                            ░██▒ ░████▒█████░      ░
                           ░▓██▒   ▒███░▓███░      ░
                           ░▓▒      ░▒░ ░▓░█▒      ░
                          ░▓▒░          ░▓░░░      ░
                         ░▓▓░           ░▓▒        ░
                        ░██░            ░▓█░       ░
                      ░▒██░             ░▓█▒       ░
                      ░▒█░               ░▒██▒░    ░
                                           ░▓██░   ░");
                Console.WriteLine("Venciste al esqueleto");
            Thread.Sleep(100);
            Console.Clear();
                Console.WriteLine(@"                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                              ░▓▓▓▓▓▒▒▒▒░           
                             ▒██████████▓░          
                             ▒████▓██████░          
                             ▓██▓▓██████▒▓░         
                            ▒▓▓▓▒▓█████▓░░█░        
                           ░███▓▒▒▓█████░ ░█░       
                          ░▓▓█░█▓░    ▒█░   █▒░     
                          ██▒▓         █▒   ▓▓░     
                          ▒█▓▓         ▓▓░  █▒░     
                          ░▒█▓         ▓█▓░▒█░      
                           ░██░        ███▒█▒       
                          ░████▒░      ░▓▓▓█▒       
                          ░▓░███▓░      ▒███▒       
                         ░▓▒ ▓██░░      ░▒██░       
                        ░█▓░            ░▒▓▒        
                      ░▒██░             ░▒█▒        
                      ░▒▓░               ░▓██▒░     
                                           ░▓██▒    ");
                Console.WriteLine("Venciste al esqueleto");
            Thread.Sleep(100);
            Console.Clear();
                Console.WriteLine(@"                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                            ░░░▓███▒░░             ░
                           ░▒▓▓███████▒            ░
                           ░██▒████████░           ░
                           ▒▓█▓▓▓████▒░▓▒░         ░
                          ░▒█▓████▓█▓░ ░▒▓░        ░
                          ░████████▓░    ░▓▓░      ░
                          ▓▓▒████████▓░   ░█▓      ░
                         ░████▒▓▓░▒▓░▒█░   ░▓      ░
                          ▒██▒░░      ░▓▓░ ░█░     ░
                          ░▓█▒         ░██▓░█░     ░
                          ░▒█▓         ░▓██░█░     ░
                          ░███▒         ░▓▓░▓▒     ░
                         ░████▓         ░▓█ ░░     ░
                         ░░▓▒░░          ▒█        ░
                         ▒▓▒             ▒█░       ░
                       ░▒██░             ░█▒       ░
                      ░▒██░              ▒██░      ░
                      ░▒▒░                ░▓█▓░    ░
                                            ░▓█▓░  ░");
                Console.WriteLine("Venciste al esqueleto");
            Thread.Sleep(100);
            Console.Clear();
                Console.WriteLine(@"                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                              ▒██▓░                 
                           ░░▒████▒                 
                        ░▓███▓▓███░                 
                       ░▒████████▓▒░░               
                       ░▓█████▓▓▒░░░▒▒▒▒░░          
                       ░███████▓░     ░▒▓▓▓▓▒░      
                       ░░▒█████▓░          ░░▒▒░    
                       ░░▒▓███░░              ░     
                       ░▒▓▓███▓▓▓▓▓▓▓▓█▓░           
                         ▒▓█▓░░░      ▓█▓░          
                          ▓▒▒          ░▓▓░         
                          ▓▓░           ░▒▒░        
                          ▒▓░             ▒█░       
                         ░█▓               ▒█░░░▒▒░ 
                         ▓█▓                ▓██████░
                        ▒██▓                ▒▒░░░░░ 
                                                    
                                                    ");
                Console.WriteLine("Venciste al esqueleto");
            Thread.Sleep(100);
            Console.Clear();
                Console.WriteLine(@"░░░░░░░░                                   ░░░░░░░░░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░
                      ░░              ░░           ░
                    ░▒██▓░           ▒█░           ░
                    ░▓███░▓▓░      ░░▓▓░           ░
                  ░▓▒▒▓▓▒▓█▓░    ░▒▓▓░░            ░
             ░▒▓▓▒▒▓▓█▓▓▓██▓▒▒▒▒▒▓▓░▒▓▒            ░
             ░▒▓█░░▒▓▓▓████▓▒░ ░░▒▓▓▒▓█            ░
               ░░   ░▒▓▓▓██▒▓█▓▓▒░   ░█░           ░
                      ░▒▓██▓░         ▒█           ░
                         ░█░           █░          ░
                         ░█▒           █▓░░░░░░    ░
                         ░███░         ▓██████▒    ░
                          ░▓▒░         ▒░░░░░░░    ░
                                                   ░
                                                   ░
                                                   ░
                                                   ░");
                Console.WriteLine("Venciste al esqueleto");
            Thread.Sleep(100);
            Console.Clear();
                Console.WriteLine(@"                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                                                    
                  ▓▓██▓░             ░░▒░           
                ░▒▓▓▓████▓▓▓░░░░░▒▒▒▓█▓▓▒           
              ░▒▒▒▒▓▓▓██████▓▓▓███▓░░░              
            ░▒▒░  ░░░░░▒▒▓█▓███▓█▓▒▒▒▒▒▒▒▒░         
    ░░▒▓▓▓▓▒░             ░▒▓█▓▒░░   ░▒██▒░         
   ▒▓▓▒░                ░░▓▓▒░   ░░▒▓▓▒░            
     ░░                 ▒█▒░   ░▓███▓▓▒             
                        ▒██▒    ░░░▓██░             
                        ░░░░                        
                                                    
                                                    
                                                    
                                                    ");
                                                    Console.WriteLine("Venciste al esqueleto");
        }
        public static void ASCIIelemental()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                                         
                                         
                        ▒                
                         ▓          ░    
           ▒████      █       ░  ▒░      
           ██▒███    ░▓▓          ░░     
           █▓ ███████▒█  ▓▓░     ░       
           ░█  █▓▒▓█▓▒░ ░▒▓   ▒▒         
             █  █▓░ ▒███████   ▒▒▓█░     
         ███ █  █████░▒▒▓▒▓▓    ███▒     
       ▓ ▓ █ ██▒ ██▓░▓▒▓ ▓▒░██▒ █        
          ██    ██▒▒██▓█▓███░            
         █████  ███▒▒▓▒▓▒▒▒▓████████▒    
        █████▒▓░██▓▓▓▓█▓▒░▒█▒░▒  ▓       
       ██▓▓▓█████▓██░░██████████▓▓█      
      ████████  ███████▓▓███ █   █ ▓█    
     █▓ ██▒█    ░ ░ ██▓▓█ ▒█      ██     
     ▓  ████         █▓▓▓░▓█▓    ▓▓█     
    █▒░   ██        ██▓░▒███▓    ███     
    █              ██░ █▓███    ░██▒     
    ▓░██       █  █▓░▓▒░████   █   ▓     
    █          ████▓▓██░ ██       █▓█    
   ▓██      ▒███████▓  ███     ██░██▒    
    █     ░  ███▒▒░░░██▒         █       
          ███▓▓▒▒▓░▓██                   
         ███░░██▒███▓██░                 
         █▓▒▓▒░██▒▓▒░░█                  
       ██▒░▒░▒▓░ ▒▓▒▒▓██▒                
      ██▒▒▓▓▓▓▓▓██▓███████▒              
  ▒████████████████▒███                  
                                         ");
                                                             Console.ForegroundColor = ConsoleColor.White;
        }
    }
}