using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Clases.ArbolBinarioOrdenado
{
    public class Carnet: Comparador 
    {
        public int carnet;
        public string descripcion;

        public bool igualQue(object q)
        {
            //throw new System.NotImplementedException();
            return true;

        }

        public bool mayorIgualQue(object q)
        {
            Carnet car = (Carnet)q;
            return carnet >= car.carnet;
            // throw new System.NotImplementedException();
        }

        public bool mayorQue(object q)
        {
            Carnet car = (Carnet)q;
            return carnet > car.carnet;
            //throw new System.NotImplementedException();
        }

        public bool menorIgualQue(object q)
        {
            Carnet car = (Carnet)q;
            return carnet <= car.carnet;
            // throw new System.NotImplementedException();
        }

        public bool menorQue(object q)
        {
            Carnet car = (Carnet)q;
            return carnet < car.carnet;
        }
    }
}
