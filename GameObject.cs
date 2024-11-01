using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderFighter
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    class GameObject
    {
        
        //游戏对象的x，y坐标
        public int X {  get; set; }
        public int Y { get; set; }
        //游戏对象的宽度和高度
        public int Width { get; set; }
        public int Height { get; set; }
        //游戏对象的速度
        public int Speed { get; set; }
        //游戏对象的生命值
        public int Life {  get; set; }
        //游戏对象的方向
        public Direction Direction { get; set; }

        public GameObject(int x, int y, int width, int height, int speed, int life, Direction dir)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Speed = speed;
            Life = life;
            Direction = dir;
        }
    }
}
