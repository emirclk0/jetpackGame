using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jetpackGame.model
{
    internal class PLAYER
    {
        private int playerX = 0, playerY = 0;
        private int playerSpeed = 18;
        private int playerWidth = 140;
        private int playerHeight = 140;

        public int PLAYERX { get => playerX; set => playerX = value; }
        public int PLAYERY { get => playerY; set => playerY = value; }
        public int PLAYERSPEED { get => playerSpeed; }
        public int PLAYERWIDTH { get => playerWidth; }
        public int PLAYERHEIGHT { get => playerHeight; }
    }

    internal class BULLET
    {
        private int bulletX, bulletY;
        private int bulletWidth = 45, bulletHeight = 15;
        private int bulletSpeed = 12;
        private Image bulletImage;

        public BULLET(int x, int y)
        {
            bulletX = x;
            bulletY = y;
        }
        public int BULLETX { get => bulletX; set => bulletX = value; }
        public int BULLETY { get => bulletY; set => bulletY = value; }
        public int BULLETWIDTH { get => bulletWidth; set => bulletWidth = value; }
        public int BULLETHEIGHT { get => bulletHeight; set => bulletHeight = value; }
        public int BULLETSPEED { get => bulletSpeed; }
        public Image BULLETIMAGE { get => bulletImage; set => bulletImage = value; }
    }
    internal class STAR
    {
        private int starX, starY;
        private Image starImage;
        public STAR(int x, int y)
        {
            starX = x;
            starY = y;
        }
        public int STARX { get => starX; set => this.starX = value; }
        public int STARY { get => starY; set => this.starY = value; }
        public Image STARIMAGE { get => this.starImage; set => this.starImage = value; }
    }

    internal class POISON
    {
        private int poisonX, poisonY;
        private int poisonWidth = 200, poisonHeight = 200;
        Image poisonImage;
        public POISON(int x, int y)
        {
            poisonX = x;
            poisonY = y;
        }
        public int POISONX { get => poisonX; set => poisonX = value; }
        public int POISONY { get => poisonY; set => poisonY = value; }
        public int POISONWIDTH { get => poisonWidth; }
        public int POISONHEIGHT { get => poisonHeight; }
        public Image POISONIMAGE { get => poisonImage; set => poisonImage = value; }
    }

    internal class FUEL
    {
        private int fuelx, fuely;

        private int fuelWidth = 30, fuelHeight = 50;

        Image fuelImage;

        public FUEL(int x, int y)
        {
            fuelx = x;
            fuely = y;
        }

        public int FUELX { get => fuelx; set => fuelx = value; }
        public int FUELY { get => fuely; set => fuely = value; }
        public int FUELWIDTH { get => fuelWidth; set => fuelWidth = value; }
        public int FUELHEIGHT { get => fuelHeight; set => fuelHeight = value; }
        public Image FUELIMAGE { get => fuelImage; set => fuelImage = value; }
    }
}
