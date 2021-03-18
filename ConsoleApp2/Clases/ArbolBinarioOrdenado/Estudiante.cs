

/**
 *
 * @author Ruldin
 */
public class Estudiante : Comparador {

    public int numMat;
    public string nombre;
    public string descripcion;

    

    public bool igualQue(object q)
    {
        //throw new System.NotImplementedException();
        return true;

    }

    public bool mayorIgualQue(object q)
    {
        Estudiante nomEs = (Estudiante)q;
        return nombre.CompareTo(nomEs.nombre)>=0;
       // throw new System.NotImplementedException();
    }

    public bool mayorQue(object q)
    {
        Estudiante nomEs = (Estudiante)q;
        return nombre.CompareTo(nomEs.nombre) > 0;
        //throw new System.NotImplementedException();
    }

    public bool menorIgualQue(object q)
    {
        Estudiante nomEs = (Estudiante)q;
        return nombre.CompareTo(nomEs.nombre) <= 0;
        // throw new System.NotImplementedException();
    }

    public bool menorQue(object q) {
        Estudiante nomEs = (Estudiante)q;
        return nombre.CompareTo(nomEs.nombre) <= 0;
    }

}
