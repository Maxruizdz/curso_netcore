// See https://aka.ms/new-console-template for more information
using curso_netCOREE.Entidades;

Console.WriteLine("Hello, World!");
Escuela escuela1 = new Escuela("Platzi Academy", 2023,
                    cuidad:    "Resistencia", pais: "Argentina"
                       );
escuela1.tipo_escuela = Tipo_Escuela.Secundaria;
Escuela escuela2 = new Escuela("UTN", 2015, Tipo_Escuela.Universidad, pais: "Argentina");
