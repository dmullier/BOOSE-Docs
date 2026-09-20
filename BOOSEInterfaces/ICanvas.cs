using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Interfaces
{
    /// <summary>
    /// Implement ICanvas for your BOOSE renderer. It has an Xpos and Ypos of the current cursor position and a pen colour.
    /// Your class should implement the methods below to draw on its "bitmap" (i.e. it may not be a bitmap, it could draw in ASCII text for example).
    /// </summary>
    public interface ICanvas
    {
        /// <summary>
        /// Set output display size. This method should create whatever drawing display you intend to use of the size specified.
        /// </summary>
        /// <param name="xsize">x size of utput display</param>
        /// <param name="ysize">y size of output display</param>
        abstract void Set(int width, int height);

        /// <summary>
        /// X position of next drawing operation.
        /// </summary>
        abstract int Xpos { get; set; }

        /// <summary>
        /// Y position of next drawing operation.
        /// </summary>
        abstract int Ypos { get; set; }


        /// <summary>
        /// Set the pen colour using rgb values.
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        abstract void SetColour(int red, int green, int blue);

        /// <summary>
        /// Move the X and Y of the next drawing operation.
        /// </summary>
        /// <param name="x">X position of cursor.</param>
        /// <param name="y">Y position of cursor.</param>
        abstract public void MoveTo(int x, int y);

        /// <summary>
        /// Draw a line using the current pen from the last drawing position to the specified position and move the cursor position to the provided x,y
        /// </summary>
        /// <param name="x">specified X position.</param>
        /// <param name="y">specified Y position.</param>
        abstract public void DrawTo(int x, int y);

        /// <summary>
        /// Fill the background in the default colour.
        /// </summary>
        abstract public void Clear();

        /// <summary>
        /// Reset drawing cursor to 0,0 and reset pen to default colour.
        /// </summary>
        abstract public void Reset();

        /// <summary>
        /// Draw a circle so that the center is the current X,Y position of radius privided. If filled is true then cursor is solid, otherwise it is just an outline.
        /// </summary>
        /// <param name="radius">Radius of circle.</param>
        /// <param name="filled">If True circle is drawn filled, outline if false.</param>
        abstract void Circle(int radius, bool filled);

       /// <summary>
       /// Draw a rectangle so that the top-left corner is the current cursor position of width and height.
       /// </summary>
       /// <param name="width"></param>
       /// <param name="height"></param>
       /// <param name="filled"></param>
        abstract void Rect(int width, int height, bool filled);
        
        /// <summary>
        /// Draw a triangle in the bounding rectangle, top-left corner is the current cursor position.
        /// </summary>
        /// <param name="width">Width of bounding rectangle.</param>
        /// <param name="height">Height of bounding rectangle.</param>
        abstract void Tri(int width, int height);
        /// <summary>
        /// Draws text on the output window at the cursor position.
        /// </summary>
        /// <param name="text">String to output</param>
        abstract void WriteText(String text);

        /// <summary>
        /// Get the drawing Object of whatever native type.
        /// Returned a Object so it can be cast to native type.
        /// Use this to get native drawing type so that it can be displayed or output.
        /// </summary>
        /// <returns></returns>
        abstract Object getBitmap();

    }
}
