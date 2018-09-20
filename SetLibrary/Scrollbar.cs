//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Text;
//using System.Drawing.Imaging;
//using System.Drawing.Drawing2D;

//namespace SetLibrary
//{
//    class Scrollbar
//    {
//        //Our channel color that we will expose later
//        protected Color moChannelColor = Color.Empty;

//        //Our images for the scrollbar that we will expose later 
//        protected System.Drawing.Image moUpArrowImage = null;
//        protected Image moDownArrowImage = null;
//        protected Image moThumbArrowImage = null;
//        protected Image moThumbTopImage = null;
//        protected Image moThumbTopSpanImage = null;
//        protected Image moThumbBottomImage = null;
//        protected Image moThumbBottomSpanImage = null;
//        protected Image moThumbMiddleImage = null;

//        //Our properties that we will expose later 

//        protected int moLargeChange = 10;
//        protected int moSmallChange = 1;
//        protected int moMinimum = 0;
//        protected int moMaximum = 100;
//        protected int moValue = 0;

//        //Our private variables for internal use 
//        private int nClickPoint;
//        private int moThumbTop = 0; 
//        private bool moThumbDown = false;
//        private bool moThumbDragging = false;

//        private Point GetMousePosition()
//        {
//            //Returns the positon of the mouse within the screen
//            return (this.PointToScreen(System.Windows.Forms.Control.MousePosition));
//        }
//    }
//}
