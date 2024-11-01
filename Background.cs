using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderFighter
{
    class Background : GameObject
    {
        private Image img;

        public Background(int x, int y, int width, int height, int speed, int life, Direction dir) : base(x, y, width, height, speed, life, dir)
        {
        }

        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }

        public override void MoveToBorder()
        {
            throw new NotImplementedException();
        }
    }
}
