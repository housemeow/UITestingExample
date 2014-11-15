using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace UITestingExample
{
    class ColorInfo
    {
        private static int _nowId = 0;
        private int _id;
        private Color _color;

        public ColorInfo(Color color)
        {
            this._id = _nowId++;
            this._color = color;
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
    }
}
