// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;


// The namespace your code is in.
namespace MohawkGame2D;

/// <summary>
///     Your game code goes inside this class!
/// </summary>
public class Game
{
    // Place your variables here:
    Player player = new Player();
    Enemy enemy = new Enemy();
    Platform platform = new Platform(0, 0, 0, 0);

    // A list of platforms
    Platform[] platforms = new Platform[]
    {
        new Platform(0, 550, 100, 50),
        new Platform(150, 450, 50, 50),
        new Platform(250, 550, 50, 50),
        new Platform(350, 500, 50, 50),
        new Platform(400, 400, 100, 50),
        new Platform(550, 550, 200, 50),
        new Platform(750, 450, 50, 50),
        new Platform(650, 400, 50, 50),
        new Platform(750, 300, 50, 50),
        new Platform(650, 250, 50, 50),
        new Platform(750, 150, 50, 50),
        new Platform(650, 50, 50, 50),
        new Platform(550, 100, 50, 50),
        new Platform(450, 50, 50, 50),
        new Platform(350, 100, 50, 50),
        new Platform(250, 50, 50, 50),
        new Platform(50, 100, 200, 50),
        new Platform(0, 50, 50, 50),
    };
    public void Setup()
    {
        Window.SetTitle("Dungeon Hopper");
        Window.SetSize(800, 600);
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(Color.Black);
        player.renderPlayer();
        enemy.renderEnemy();
        platform.renderPlatforms();
        player.movePlayer();
        player.updateMovement(platforms);
        foreach (var platform in platforms)
        {
            platform.renderPlatforms();
        }
    }

}
    



