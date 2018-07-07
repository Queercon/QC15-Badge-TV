using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace se.nightri.QC15_TV_Badge
{

    class DrawFile : DrawingArea
    {

        protected override void OnDraw()
        {
            // Gets the image from the global resources
            //Image broculoImage = global::WindowsApplication1.Properties.Resources.broculo;

            // Sets the images' sizes and positions
            //int width = broculoImage.Size.Width;
            //int height = broculoImage.Size.Height;
            //Rectangle big = new Rectangle(0, 0, width, height);
            //Rectangle small = new Rectangle(50, 50, (int)(0.75 * width), (int)(0.75 * height));

            // Draws the two images
            //this.graphics.DrawImage(broculoImage, big);
            //this.graphics.DrawImage(broculoImage, small);

            // Sets the text's font and style and draws it
            float fontSize = 16f;
            Point textPosition = new Point(50, 100);

            DrawText("X X X X X X", "Courier New", fontSize
                , FontStyle.Regular, Brushes.Lime, textPosition);
            textPosition = new Point(50, 100);
            DrawText(" 0 0 0 0 0 0", "Courier New", fontSize
                , FontStyle.Regular, Brushes.Lime, textPosition);
        }

    }

}


