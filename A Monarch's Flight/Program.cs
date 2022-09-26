﻿Random rnd = new Random();
string spawnMessage1;
string spawnMessage2;
string spawnMessage3;
string deathMessage1;
string deathMessage2;
string deathMessage3;
int enemyChance = 0;
int Number;
int enemyHP = 0;
int playerHP = 100;
int enemydamage;
int playerblockchance;
int playerCritchance;
int enemyCritchance;
int Heals = 3;
int healthgain;
int playerSlashDamage = 0;
int playerThrustDamage = 0;
int playerFryDamage = 0;
int e = 0;

string room = "room";
string answer = "n";
string movechoice = "";
string fightflight = "";


spawnMessage1 = "High Priest Pucci appeared before you";
spawnMessage2 = "The Palace Chef appeared before you";
spawnMessage3 = "The enemy prisoner appeared before you";
deathMessage1 = "High Priest Pucci has finally been eliminated and you have regained your throne";
deathMessage2 = "You deafeated the Palace Chef, no more food for a while";
deathMessage3 = "You vanquished the enemy prisoner";

Boolean blocking = false;
Boolean enemy1Spawned = false;
Boolean enemy2Spawned = false;
Boolean enemy3Spawned = false;
Boolean sword = true;
Boolean fryingPan = false;
Boolean knife = false;

switch (fightflight)
{
    case "Fight":
        Console.WriteLine("You decided to fight the prisoner");
        enemyChance = 1;
        break;

    case "Flee":
        enemyChance = 0;
        Console.WriteLine("You chose to flee from the prisoner");
        break;

}

switch (movechoice)
{
    case "Left":
        Console.WriteLine(@"     \                  ###########                  /
      \                  #########                  /
       \                                           /
        \                                         /
         \                                       /
          \                                     /
           \                                   /
            \_________________________________/
            |                                 |
            |                                 |
            |                                 |
            |            _________            |
            |           |         |           |
            |           |   ___   |           |
            |           I  |___|  |           |
            |           |         |           |
            |           |         |           |
            |           |        _|           |
            |           |       |#|           |  ;,
    -- ___  |           |         |           |   ;'
    H*/   ` |           |         |      _____|    .,`
    */     )|           I         |     \_____\     ;'
    /___.,';|           |         |     \\     \     .""`
    |     ; |___________|_________|______\\     \      ;:
    | ._,'  /                             \\     \      .
    |,'    /                               \\     \
    ||    /                                 \\_____\
    ||   /                                   \_____|
    ||  /              ___________                \
    || /              / =====o    |                \
    ||/              /  |   /-\   |                 \
    //              /   |         |                  \
   //              /    |   ____  |______             \
  //              /    (O) |    | |      \             \
 //              /         |____| |  0    \             \
//              /          o----  |________\             \
/              /                  |     |  |              \
              /                   |        |               \
             /                    |        |             leb
            /                     |        |

");
        Console.WriteLine("A prisoner appears in your cell before you, what would you like to do? [Fight] [Flee]");
        fightflight = Console.ReadLine();
        room = "cell";
        e = 1;
        break;

    case "Right":
        Console.WriteLine(@"   ____________________________________________________________________    
 /|    |__I__I__I__I__I__I__I__I__I_|       _-       %       %         |\
  | _- |_I__I__I__I__I__I__I__I__I__|-_              %       %     _-  | 
  |    |__I__I__I__I__I__I__I__I__I_|                %       %         |
  |  - |_I__I__I__I__I__I__I__I__I__|               ,j,      %w ,      |
  | -  |__I__I__I__I__I__I__I__I__I_|  -_ -        / ) \    /%mMmMm.   |
  |    |_I__I__I__I__I__I__I__I__I__|             //|  |   ;  `.,,'    |
  |-_- /                            \             w |  |   `.,;`       |
  |   /                              \    -_       / ( |    ||         |
  |  /                                \           //\_'/    (.\    -_  |
  | /__________________________________\          w  \/   -  ``'       |
  | |__________________________________|                               |
  |    |   _______________________   |     _-            -             |
  |_-  |  |                       |  |                        _-       |
  |    |  |                     _ |  |  T  T  T  T  T                  |
  | _-_|  |    __.'`'`'`''`;__ /  |  |  |  |  |  |  |        _-     -  |
  |    |  | _/U  `'.'.,.,"".'  U   |  |  | (_) |  |  |                  |
  |    |  |   |               |   |  | / \    @ [_]d b    _@_     |    |   
  |    |  |   |      `', `,   |   |  | |_|   ____         [ ]     |    |
  |_-  |  |   |   `') ( )'    |   |  | ______\__/_________[_]__   |    | 
  |    |  |   |____(,`)(,(____|   |  |/________________________\  |    |
  |    |  |  /|   `@@(@@)@)'  |\  |  | ||            _____   ||   |    |
  |    |  | //!\  @@)@@)@@@( /!\\ |  | ||   _--      \   /   ||  /|\   |
  |__lc|__|/_____________________\|__|_||____________/###\___||_|||||__|
 / -_  _ -      _ -   _-_    -  _ - _ -|| -_    _  - \___/_- || |||||-_ \ ");
        Console.WriteLine("You chose to enter the kitchen, and the chef appears before you, what would you like to do? [Fight] [Flee]");
        fightflight = Console.ReadLine();
        room = "Kitchen";
        e = 2;
        break;
}

switch (e)
{
    case 1:
        enemy1Spawned = true;
        enemyHP = rnd.Next(150, 300);
        break;
    case 2:
        enemy2Spawned = true;
        enemyHP = rnd.Next(75, 125);
        break;
    case 3:
        enemy3Spawned = true;
        enemyHP = rnd.Next(50, 100);
        break;

}

void pucciMsg()
{
    Console.WriteLine($"High Priest Pucci has {enemyHP} Health");
    Thread.Sleep(2000);

    if (fryingPan != true)
    {
        Console.WriteLine("What would you like to do? [Stab] [Thrust] [Block] [Heal]");
        Thread.Sleep(2000);
    }

    else
    {
        Console.WriteLine("What would you like to do [Smack] [Block] [Heal]");
    }
}

void chefMsg()
{
    Console.WriteLine($"The Palace Chef has {enemyHP} Health");
    Thread.Sleep(2000);

    if (fryingPan != true)
    {
        Console.WriteLine("What would you like to do? [Stab] [Thrust] [Block] [Heal]");
        Thread.Sleep(2000);
    }

    else
    {
        Console.WriteLine("What would you like to do [Smack] [Block] [Heal]");
    }
}
void pucciCrit()
{
    if (enemyCritchance == 1)
    {
        Console.WriteLine("High Priest Pucci has contolled his emotions and packed them into a single devastating punch!");
        Thread.Sleep(1000);
        enemydamage = enemydamage * 2;
        playerHP = playerHP - enemydamage;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);
    }
}

void chefCrit()
{
    if (enemyCritchance == 1)
    {
        Console.WriteLine("The Palace Chef has used his knowledge about food and cutlery to predict what your next move would be and strikes where it would hurt you most!");
        Thread.Sleep(1000);
        enemydamage = enemydamage * 2;
        playerHP = playerHP - enemydamage;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);
    }
}

void pucciCritless()
{
    if (enemyCritchance != 1)
    {
        Console.WriteLine($"High Priest Pucci dealt you {enemydamage} damage ");
        playerHP = playerHP - enemydamage;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);
    }
}

void chefCritless()
{
    if (enemyCritchance != 1)
    {
        Console.WriteLine($"The Palace Chef dealt you {enemydamage} damage ");
        playerHP = playerHP - enemydamage;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);
    }
}

void pucciAttack()
{
    Thread.Sleep(1000);
    Console.WriteLine($"High Priest Pucci has {enemyHP} Health");

    pucciCrit();

    pucciCritless();
}

void chefAttack()
{
    Thread.Sleep(1000);
    Console.WriteLine($"The Palace Chef has {enemyHP} Health");

    chefCrit();

    chefCritless();
}

void playerSlashCrit()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Thread.Sleep(1000);
    Console.WriteLine("You get ready to release your anger upon your enemy!");
    Thread.Sleep(1000);
    Thread.Sleep(1000);

    playerSlashDamage = playerSlashDamage * 2;
    Console.WriteLine($"You were able to slash your enemy with your weapon {playerSlashDamage} Damage!");

    enemyHP = enemyHP - playerSlashDamage;
    Console.ForegroundColor = ConsoleColor.White;
}

void playerThrustCrit()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Thread.Sleep(1000);
    Console.WriteLine("You get ready to release your anger upon your enemy!");
    Thread.Sleep(1000);
    Thread.Sleep(1000);

    playerThrustDamage = playerThrustDamage * 2;
    Console.WriteLine($"You managed to thrust your weapon into your enemy's body and dealt {playerThrustDamage} Damage!");

    enemyHP = enemyHP - playerThrustDamage;
    Console.ForegroundColor = ConsoleColor.White;
}

void playerFryCrit()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Thread.Sleep(1000);
    Console.WriteLine("You get ready to release your anger upon your enemy!");
    Thread.Sleep(1000);
    Thread.Sleep(1000);

    playerThrustDamage = playerThrustDamage * 2;
    Console.WriteLine($"You were able to smack your enemy in the head with your frying pan and dealt {playerThrustDamage} Damage!");

    enemyHP = enemyHP - playerThrustDamage;
    Console.ForegroundColor = ConsoleColor.White;
}

void blockedPucci()
{
    if (playerblockchance == 1 && enemyCritchance != 1)
    {
        Console.WriteLine($"High Priest Pucci dealt you {enemydamage} damage ");
        Console.WriteLine("However, you were able to put your guard up in time, and Pucci hardly dealt any damage to you");
        playerHP = playerHP - 1;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);

    }
}

void blockedChef()
{
    if (playerblockchance == 1 && enemyCritchance != 1)
    {
        Console.WriteLine($"The Palace Chef attempted to deal you {enemydamage} damage ");
        Console.WriteLine("However, you were able to put your guard up in time, and hardly dealt any damage to you");
        playerHP = playerHP - 1;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);

    }
}

void blockedPucciFail()
{
    if (playerblockchance == 1 && enemyCritchance == 1)
    {
        Console.WriteLine("High Priest Pucci has contolled his emotions and packed them into a single devastating punch!");
        Thread.Sleep(1000);
        Console.WriteLine("You attempted to block High Priest Pucci's attack, but he broke through your guard and hit you with his devastating punch!");
        enemydamage = enemydamage * 2;
        playerHP = playerHP - enemydamage;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);
    }
}

void blockedChefFail()
{
    if (playerblockchance == 1 && enemyCritchance == 1)
    {
        Console.WriteLine("The Palace Chef has contolled their emotions and packed them into a single devastating punch!");
        Thread.Sleep(1000);
        Console.WriteLine("You attempted to block The Palace Chef's attack, but they broke through your guard and hit you with their devastating attack!");
        enemydamage = enemydamage * 2;
        playerHP = playerHP - enemydamage;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);
    }
}

void pucciKill()
{
    if (playerHP <= 0)
    {
        Console.WriteLine("High Priest Pucci has defeated you and stolen your throne");
    }
}

void chefKill()
{
    if (playerHP <= 0)
    {
        Console.WriteLine("The Palace chef has defeated you and allowed High Priest Pucci to steal your throne");
    }
}

void pucciDeath()
{
    if (enemyHP <= 0)
    {
        enemy1Spawned = false;
        Console.WriteLine(deathMessage1);
    }
}

void chefDeath()
{
    if (enemyHP <= 0)
    {
        enemy2Spawned = false;
        Console.WriteLine(deathMessage2);
    }
}

void rndDam()
{
    playerCritchance = rnd.Next(0, 10);
    enemyCritchance = rnd.Next(0, 10);

    playerblockchance = rnd.Next(0, 6);
    playerSlashDamage = rnd.Next(12, 50);
    playerThrustDamage = rnd.Next(2, 75);
    playerFryDamage = rnd.Next(0, 50);
    enemydamage = rnd.Next(9, 35);
}


Console.WriteLine("You woke up in a dark room with a light to both sides. Which way would you like to go? [Left] [Right]");
movechoice = Console.ReadLine();

Console.WriteLine(e);
if (enemyChance == 1 && e == 1)
{
    enemy1Spawned = true;
    Console.WriteLine(spawnMessage1);
    Thread.Sleep(1000);
    Console.WriteLine(@"                                                                                                                                                                                  
                                                ▄█████▄                                   
                                             ▄█████████▓█                                 
                                             █▀███║▀███▒▀k                                
                                             ███║╣▓╢▓█▓▓▒▒                                
                                             ▀▀█Ü▒╣╣▓▓▌╫▒░                                
                                             ▒▒╪▓▓ÜÄ▒▓█┼▒▒                                
                                              ╙▓▒╣▓▓▓▓▓▒▒`                                
                                              ▌▒▓╣╫▓▓╝░░▒                                 
                                 ╓h╖,,,,,,≡rò░░▀▄▀▀▓╢@φ¢'                                 
                              ╓¢░░░░░░░, `░░░░░▐φ▒╓╓``¿g ░░                               
                               ░░`░░`░░░░░░░░░ ▐╣██╣  '`░░ ░░,                            
                            ░░░`░ `.░░█▀▒░░░░░▓▒▒▒▀░`░░░░'░`'░░░,                         
                        ,≡▒░───░░░░▀████▄░░░░█▀▒█▒░░░░░░░░,,    ░░k                       
                     ╓m░░░░░░░░░░░░½█▀▒▀▀████▒██╜░░░░g░░░░░░░░░░░░░░m┐                    
                  ┌░░░░░░░░░░░░░'░░░▀░░░░½█▀▒████▄┤░░██░░░░`░░ ░░░░░░░`                   
               «Ü░░░░░`     ░      ░░░░░░╫▀▒█▀░┤▀▀████▄░░░░ ░░░░░░░`                      
               ░ `░░░░░░        ]░░░░░░░█▒g▒░`░░░░▒█▒▀▀█▌░░`░░░░░░   ░                    
                ░░░░░░░         ░░░░` ░▒█▒█▌░░. '▀▀▒░░░░░░` ░ '░``,░░                     
                ░░░░░░░          ░░ ░░░█▒█▌░░░░░░           ` ░░░░░░                      
                ░░░░░░           ░░░░░▐▓▒█▒░░░░░░░░░░░░░'  ░,░,░░.`░                      
                 ░░░░░,         ░░░░░░▓▌▓▌` `░░░░░░'`  ░    ░░`░░`                        
                 ░░░░`░░        └░'░░░▓▒▓▒   `░░░░          ░░░░░░                        
                  ╞███▒@         ░  ░▐▌▒▓C    '            /░░░░░$@█                      
                   ██▀▒╜         ░  ░▓▒▓▒         ░        ░░░░░██▌█Ü▄                    
                    ░░░░░░     ]░░░ ░╜░▒~     ░░  ,        ¿░░░▐█║▒▒▒▓▄ ,▄,               
                     ░░░░░░,   ░░ ░▄▒░╢░     ░░  ░░        ░░░▓▓▀▒▒▒▒▒▒╝└╙""               
                      ░▄████▒▀░ ░░ ▒▒█▒,,░' ░░░░           ░░░░ÑH▒▒▒▒▒                    
                       ▒█▀▓▀█░░ ░░░░▒▒▒░  ░' ░             ░`   `'`                       
                       ▐▌ ▀▄,█¿░░ `▀▒Æ▌░░` ░░░░░            `░   ░                        
                       ▐▌  ▀▌░▀ ▒░ ▐▒▒▒`  ░ ░░░░░`   ░                                    
                        ▒   ░░░ ░▒`▓▒▓▌  ░  ░░░`░░                                        
                            `░░░'░░▓▒╟▌░░ ,░░░¿░░                                         
                            ░░░ ░░ ▒▒▐▒░░░,░░░░░░░                                        
                            ░░░░ ░ └▒▒░`░░▒░░░░░░                                         
                            ▒`░░░ ░░▒░░░░░░░░░░░░    ░                                    
                            ║░░░░  ▐░░░░░░░░░░`                                           
                            ]░`░░░ ░░░░░░░░░░░░░░`                                        
                             ▒░`░░░░░▒▒▒░░░░░░░░                                          
                             ]░░`░░▒░░░░░░░░░░                                            
                              ▒░░░░░░░░░░░░`                                              
                              ]░▒░░░░░░░                                                  
                               ░▒░░░░░      ░░                                            
                              ╓╣░░░░░░░'''    ░                                           
                              ▒▒░░░░░░                                                    
                                 `░░░░░░      `                                           
                                ░.  ░░░░░░,     '                                         
                               ░░,`░░░░░░░░░░░,,  ░»»,,,,,╖╖╖╖╖╖╖,,,                      
                             ]░░░░▒╖░░`░░░░░░░░░░░░    `'░░``'░░░░░░░░▒                   
                             ░░░░╘W░░░▒░,   `░░░░~,`              `░░░░░,                 
                          .░░░░▒░░░░╚╨φ▄░░░░░░░░░░░░░░░─,`              ░                 
                       ,ó░░░ ░█░░░░░   '▀▀N▄░░░░░░░░░░░░░░░░─, ░                          
                     ∩▒░ ░░░░█▌░░░░░░  ░   ""▀▀█φ░░░░░░░░░░░░░░░▒─,                        
                   ╓▒`  ░░░░▐█▒░░░░░░░  ░      ╙▀██▄░░░░░░░░░░░░░░░                       
                  ]░`  ░░░░░█▌░░░░░░░`   '        '▀▀█&▄░░░░░░░░░░░▒                      
                  ░░   ░░░░╟█▒╜` ▒░░h      ░          ╙▀██▄░░░░░░░░─                      
                  ░    ░░░░██`   ▒░░h   ░   ░         ░  ╙▀██▄░░░░░                       
                      ░░░░░█▌    ╙▒▒     ░   ░░             ▀▀██g░`                       
                      ┌░░░▐█▌                `░░              '▀██                        
                       ░░░▐█▌                 ░░        ░,       ""                        
                         `╙█▌                   ░        ░░░                              
                                               `  ░¿░   ░░░░╢▓                            
                                            ∩─     ░░,░░░░░║▒╩                            
                                             ░      \░░░░░]╙""                             
                                              ░░░   `░░░░░░                               
                                              ░░`    ║@░░░░K                              
                                            ╔╣▒░,    ║▒▒░░j                               
                                         ╓@▒▒▒░░░░░░░╢╜░░)                                
                                    ╓Ñ╜╙╜░░░░░░,░╛╢╢ß▒░░X                                 
                                   ╙┴═+~∞░░░░═`   ╙╜╜╙╜└                                  
");
}

else if (enemyChance != 1)
{
    enemy1Spawned = false;
    enemy2Spawned = false;
    enemy3Spawned = false;
}

if (enemy1Spawned == true)
{
    while (enemy1Spawned == true)
    {
        pucciMsg();
        answer = Console.ReadLine();

        if (fryingPan != true)
        {
            if (answer == "Slash" ^ answer == "slash" ^ answer == "1" ^ answer == "s")
            {
                rndDam();

                if (playerCritchance == 1)
                {
                    playerSlashCrit();
                }

                else if (playerCritchance != 1)
                {
                    Console.WriteLine($"You slashed your weapon at High Priest Pucci for {playerSlashDamage} damage");
                    enemyHP = enemyHP - playerSlashDamage;
                }

                if (enemyHP > 0 && playerHP > 0)
                {
                    pucciAttack();
                }

                pucciDeath();

                pucciKill();
            }

            if (answer == "Thrust" ^ answer == "thrust" ^ answer == "2" ^ answer == "t")
            {
                rndDam();

                if (playerCritchance == 1)
                {
                    playerThrustCrit();
                }

                else if (playerCritchance != 1)
                {
                    Console.WriteLine($"You thrust  your weapon into High Priest Pucci for {playerThrustDamage} damage");
                    enemyHP = enemyHP - playerSlashDamage;
                }

                if (enemyHP > 0 && playerHP > 0)
                {
                    pucciAttack();
                }

                pucciDeath();

                pucciKill();
            }

            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
            {

                rndDam();
                playerblockchance = 1;

                blockedPucci();
                blockedPucciFail();
                pucciKill();
            }
        }

        else if (fryingPan == true)
        {
            if (answer == "Smack" ^ answer == "smack" ^ answer == "1" ^ answer == "s")
            {
                rndDam();

                if (playerCritchance == 1)
                {
                    playerFryCrit();
                }

                else if (playerCritchance != 1)
                {
                    Console.WriteLine($"You stabbed High Priest Pucci for {playerFryDamage} damage");
                    enemyHP = enemyHP - playerFryDamage;
                }

                if (enemyHP > 0 && playerHP > 0)
                {
                    pucciAttack();
                }

                pucciDeath();

                pucciKill();
            }
        }
    }
}

else if (enemyChance == 1 && e == 2)
{
    enemy2Spawned = true;
    Console.WriteLine(spawnMessage2);
    Thread.Sleep(1000);
    Console.WriteLine(@"       .--,--.
                               `.  ,.'
                                |___|
                                :o o:   O    
                               _`~^~'_  |    
                             /'   ^   `\=)
                           .'  _______ '~|
                           `(<=|     |= /'
                               |     |
                               |_____|
                        ~~~~~~~ ===== ~~~~~~~~");
}

else if (enemyChance != 1)
{
    enemy1Spawned = false;
    enemy2Spawned = false;
    enemy3Spawned = false;
}

if (enemy2Spawned == true)
{
    while (enemy2Spawned == true)
    {
        chefMsg();
        answer = Console.ReadLine();

        if (fryingPan != true)
        {
            if (answer == "Slash" ^ answer == "slash" ^ answer == "1" ^ answer == "s")
            {
                rndDam();

                if (playerCritchance == 1)
                {
                    playerSlashCrit();
                }

                else if (playerCritchance != 1)
                {
                    Console.WriteLine($"You were able to slash the Palace Chef for {playerSlashDamage} damage");
                    enemyHP = enemyHP - playerSlashDamage;
                }

                if (enemyHP > 0 && playerHP > 0)
                {
                    chefAttack();
                }

                chefDeath();

                chefKill();
            }

            if (answer == "Thrust" ^ answer == "thrust" ^ answer == "2" ^ answer == "t")
            {
                rndDam();

                if (playerCritchance == 1)
                {
                    playerThrustCrit();
                }

                else if (playerCritchance != 1)
                {
                    Console.WriteLine($"You thrust  your weapon into High Priest Pucci for {playerThrustDamage} damage");
                    enemyHP = enemyHP - playerSlashDamage;
                }

                if (enemyHP > 0 && playerHP > 0)
                {
                    chefAttack();
                }

                chefDeath();

                chefKill();
            }

            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
            {

                rndDam();
                playerblockchance = 1;

                blockedChef();
                blockedChefFail();
                chefKill();
            }
        }

        else if (fryingPan == true)
        {
            if (answer == "Smack" ^ answer == "smack" ^ answer == "1" ^ answer == "s")
            {
                rndDam();

                if (playerCritchance == 1)
                {
                    playerFryCrit();
                }

                else if (playerCritchance != 1)
                {
                    Console.WriteLine($"You were able to smack the Palace Chef for {playerFryDamage} damage");
                    enemyHP = enemyHP - playerFryDamage;
                }

                if (enemyHP > 0 && playerHP > 0)
                {
                    chefAttack();
                }

                chefDeath();

                chefKill();
            }
        }
    }
}

else if (enemyChance == 1 && e == 3)
{
    Console.WriteLine("Unfinished");
}

