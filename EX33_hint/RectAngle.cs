using EX33_hint;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX33_hint
{
    class RectAngle : ISurface, ICircumference, IBounds
    {
        readonly public float width;
        readonly public float height;
        public RectAngle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public float GetSurface()
        {
            return width * height;
        }
        public float GetCircumference()
        {
            return (width + height) * 2;
        }
        public void GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
        }
        public static bool operator ==(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width;
        }
        
        public static bool operator !=(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return !(rectAngle1 == rectAngle2);
        }

        public static RectAngle operator +(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            int select_calculating_method = 0;
            RectAngle[] choice = new RectAngle[4];
            choice[0] = new RectAngle(rectAngle1.height + rectAngle2.height, MathF.Max(rectAngle1.width, rectAngle2.width));
            choice[1] = new RectAngle(rectAngle1.width + rectAngle2.width, MathF.Max(rectAngle1.height, rectAngle2.height));
            choice[2] = new RectAngle(rectAngle1.height + rectAngle2.width, MathF.Max(rectAngle1.width, rectAngle2.height));
            choice[3] = new RectAngle(rectAngle1.width + rectAngle2.height, MathF.Max(rectAngle1.height, rectAngle2.width));
            for(int i =1;i< choice.Length; i++)
            {
                if (choice[i].width * choice[i].height < choice[select_calculating_method].width * choice[select_calculating_method].height)
                {
                    select_calculating_method = i;
                }
            }
            return choice[select_calculating_method];
        }
    }
}
