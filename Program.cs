// See https://aka.ms/new-console-template for more information
using curso_netCOREE.APP;
using curso_netCOREE.Entidades;
EscuelaEngine escuelaEnginer = new EscuelaEngine();
escuelaEnginer.Inicializar();
escuelaEnginer.escuela.limpiar_lugar();
var lista_objetos = escuelaEnginer.GetObjetosEscuela();

var listaIlugar = from obj in lista_objetos
                  where obj is Ilugar
                  select (Ilugar) obj;

