using OpenGL.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenGL
{

    class Objeto
    {
        List<Cara> list;

        public Objeto()
        {
            list = new List<Cara>();
        }

        public void addCara(Cara cara)
        {
            list.Add(cara);
        }

        public void render(Camera _camera)
        {
            foreach (Cara cara in  list)
            {
                cara.render(0, _camera);
            }
        }

        public void dispose()
        {
            foreach (Cara cara in list)
            {
                cara.dispose();
            }

        }


    }
}
