// See https://aka.ms/new-console-template for more information
using curso_netCOREE.Entidades;

Console.WriteLine("Hello, World!");
Escuela escuela = new Escuela("Platzi Academy", 2023,
                    cuidad:    "Resistencia", pais: "Argentina"
                       );
escuela.tipo_escuela = Tipo_Escuela.Secundaria;
Console.WriteLine(escuela);