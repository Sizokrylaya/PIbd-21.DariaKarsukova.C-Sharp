﻿using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;


namespace WindowsFormsPlane
{
    public class Fighter : Plane
    {

        protected const int planeWidth= 200;
        protected const int planeHeight = 140;
        public Fighter(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (StartPosX + step < pictureWidth - planeWidth)
                    {
                        StartPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (StartPosX - step > -planeWidth/4)
                    {
                        StartPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (StartPosY - step > 0)
                    {
                        StartPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (StartPosY + step < pictureHeight - planeHeight)
                    {
                        StartPosY += step;
                    }
                    break;
            }
        }
        public override void DrawFighter(Graphics g)
        {

            Pen pen = new Pen(Color.Black);


            Brush jr = new SolidBrush(MainColor);
            g.FillEllipse(jr, StartPosX + 28, StartPosY + 40, 140, 30);
            g.DrawEllipse(pen, StartPosX + 28, StartPosY + 40, 140, 30);

            g.FillEllipse(jr, StartPosX + 60, StartPosY + 130, 80, 15);
            g.DrawEllipse(pen, StartPosX + 60, StartPosY + 130, 80, 15);

            Brush wing = new SolidBrush(MainColor);
            g.FillEllipse(wing, StartPosX + 80, StartPosY - 6, 40, 160);
            g.DrawEllipse(pen, StartPosX + 80, StartPosY - 6, 40, 160);

            Brush pp = new SolidBrush(Color.Gray);
            g.FillEllipse(pp, StartPosX + 85, StartPosY + 26, 30, 15);
            g.DrawEllipse(pen, StartPosX + 85, StartPosY + 26, 30, 15);

            g.FillEllipse(jr, StartPosX + 97, StartPosY + 120, 7, 30);
            g.DrawEllipse(pen, StartPosX + 97, StartPosY + 120, 7, 30);

            g.DrawLine(pen, StartPosX + 100, StartPosY + 25, StartPosX + 100, StartPosY + 40);


        }
    }

}
