using OpenGL.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenGL
{
    class Escenario
    {
        Dictionary<string, Objeto> dictionary;

        public Escenario()
        {
            float x = 0;
            float y = 0;
            float z = 0;

            dictionary = new Dictionary<string, Objeto>();


            initCubo(0.5f, 0.5f, 0.5f, x, y, z, "Cubo1");

            x = 1.5f;
            initPiramide(1, 1, 1, x, y, z, "Piramide1");

            z = 1.5f;
            initPiramide(0.8f, 0.8f, 0.8f, x, y, z, "Piramide2");
        }


        public void agregarObjeto(Objeto objeto, String t)
        {
            dictionary.Add(t, objeto);
        }

        public Objeto buscarObjeto(String t)
        {
            return dictionary[t];
        }

        public void render(Camera _camera)
        {
            
            foreach (KeyValuePair<string, Objeto> objeto in dictionary)
            {
                objeto.Value.render(_camera);
            }

        }

        public void dispose()
        {
            foreach (KeyValuePair<string, Objeto> objeto in dictionary)
            {
                objeto.Value.dispose();
            }

        }


        public void initCubo(float l, float h, float a, float x, float y, float z, string name)
        {

            //Cubo
            Objeto cubo = new Objeto();
            List<float> puntos = new List<float>();
            puntos.Add(l); puntos.Add(0); puntos.Add(0);
            puntos.Add(0); puntos.Add(0); puntos.Add(0);
            puntos.Add(0); puntos.Add(h); puntos.Add(0);
            puntos.Add(l); puntos.Add(h); puntos.Add(0);
            Cara cara1 = new Cara(puntos, x, y, z, 0f, 1f, 1f, 1f);

            puntos.Clear();
            puntos.Add(l); puntos.Add(0); puntos.Add(a);
            puntos.Add(l); puntos.Add(0); puntos.Add(0);
            puntos.Add(l); puntos.Add(h); puntos.Add(0);
            puntos.Add(l); puntos.Add(h); puntos.Add(a);
            Cara cara2 = new Cara(puntos, x, y, z, 1f, 0f, 1f, 1f);

            puntos.Clear();
            puntos.Add(0); puntos.Add(0); puntos.Add(0);
            puntos.Add(0); puntos.Add(0); puntos.Add(a);
            puntos.Add(0); puntos.Add(h); puntos.Add(a);
            puntos.Add(0); puntos.Add(h); puntos.Add(0);
            Cara cara3 = new Cara(puntos, x, y, z, 1f, 1f, 0f, 1f);

            puntos.Clear();
            puntos.Add(0); puntos.Add(0); puntos.Add(0);
            puntos.Add(l); puntos.Add(0); puntos.Add(0);
            puntos.Add(l); puntos.Add(0); puntos.Add(a);
            puntos.Add(0); puntos.Add(0); puntos.Add(a);
            Cara cara4 = new Cara(puntos, x, y, z, 0f, 0f, 1f, 1f);

            puntos.Clear();
            puntos.Add(0); puntos.Add(0); puntos.Add(a);
            puntos.Add(l); puntos.Add(0); puntos.Add(a);
            puntos.Add(l); puntos.Add(h); puntos.Add(a);
            puntos.Add(0); puntos.Add(h); puntos.Add(a);
            Cara cara5 = new Cara(puntos, x, y, z, 0f, 1f, 0f, 1f);

            puntos.Clear();
            puntos.Add(0); puntos.Add(h); puntos.Add(a);
            puntos.Add(l); puntos.Add(h); puntos.Add(a);
            puntos.Add(l); puntos.Add(h); puntos.Add(0);
            puntos.Add(0); puntos.Add(h); puntos.Add(0);
            Cara cara6 = new Cara(puntos, x, y, z, 1f, 0f, 0f, 1f);

            cubo.addCara(cara1);
            cubo.addCara(cara2);
            cubo.addCara(cara3);
            cubo.addCara(cara4);
            cubo.addCara(cara5);
            cubo.addCara(cara6);
            agregarObjeto(cubo, name);
        }

        public void initPiramide(float l, float h, float a, float x, float y, float z, string name)
        {

            //Piramide
            Objeto piramide = new Objeto();
            List<float> puntos = new List<float>();
            puntos.Add(0); puntos.Add(0); puntos.Add(0);
            puntos.Add(l); puntos.Add(0); puntos.Add(0);
            puntos.Add(l); puntos.Add(0); puntos.Add(a);
            puntos.Add(0); puntos.Add(0); puntos.Add(a);
            Cara cara1 = new Cara(puntos, x, y, z, 0f, 1f, 1f, 1f);

            puntos.Clear();
            puntos.Add(l); puntos.Add(0); puntos.Add(0);
            puntos.Add(0); puntos.Add(0); puntos.Add(0);
            puntos.Add(l / 2.0f); puntos.Add(h); puntos.Add(a / 2.0f);
            Cara cara2 = new Cara(puntos, x, y, z, 1f, 0f, 1f, 1f);

            puntos.Clear();
            puntos.Add(l); puntos.Add(0); puntos.Add(a);
            puntos.Add(l); puntos.Add(0); puntos.Add(0);
            puntos.Add(l / 2.0f); puntos.Add(h); puntos.Add(a / 2.0f);
            Cara cara3 = new Cara(puntos, x, y, z, 1f, 1f, 0f, 1f);

            puntos.Clear();
            puntos.Add(0); puntos.Add(0); puntos.Add(0);
            puntos.Add(0); puntos.Add(0); puntos.Add(a);
            puntos.Add(l / 2.0f); puntos.Add(h); puntos.Add(a / 2.0f);
            Cara cara4 = new Cara(puntos, x, y, z, 0f, 0f, 1f, 1f);

            puntos.Clear();
            puntos.Add(0); puntos.Add(0); puntos.Add(a);
            puntos.Add(l); puntos.Add(0); puntos.Add(a);
            puntos.Add(l / 2.0f); puntos.Add(h); puntos.Add(a / 2.0f);
            Cara cara5 = new Cara(puntos, x, y, z, 0f, 1f, 0f, 1f);

            
            piramide.addCara(cara1);
            piramide.addCara(cara2);
            piramide.addCara(cara3);
            piramide.addCara(cara4);
            piramide.addCara(cara5);
            
            agregarObjeto(piramide, name);
        }

    }
}
