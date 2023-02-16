// See https://aka.ms/new-console-template for more information
using curso_netCOREE.APP;
using curso_netCOREE.Entidades;
EscuelaEngine escuelaEnginer = new EscuelaEngine();
escuelaEnginer.Inicializar();
escuelaEnginer.escuela.limpiar_lugar();
var lista_objetos = escuelaEnginer.GetObjetosEscuela(trae_evaluaciones:false);

var listaIlugar = from obj in lista_objetos
                  where obj is Evaluacion
                  select (Evaluacion) obj;


Console.WriteLine(lista_objetos.Count);


/*foreach (var Ilugar in listaIlugar) {


    Console.WriteLine(lista_objetos.Count);


}

*/