using System;

namespace NominaIstitucional
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // PRUEBA DE MI PROGRAMA
            // INTANCIACION DE LAS 3 CLASE DE PRUEBA

            // Instanciación de un Docente por Hora
            DocentePorHora docentePorHora = new DocentePorHora("Juan", "Perez", 1, "DocentePorHora", 0);
            int salarioDocentePorHora = docentePorHora.CalcularSalario(40); // 40 horas trabajadas
            Console.WriteLine($"Salario Docente por Hora: {salarioDocentePorHora}");

            // Instanciación de un Docente de Contrato Fijo
            DocenteContratoFijo docenteContratoFijo = new DocenteContratoFijo("Ana", "Gomez", 2, "DocenteContratoFijo", 3000);
            int salarioDocenteContratoFijo = docenteContratoFijo.CalcularSalario();
            int bonificacionDocenteContratoFijo = docenteContratoFijo.CalcularBonificacion(true); // Alcanzó la meta
            Console.WriteLine($"Salario Docente de Contrato Fijo: {salarioDocenteContratoFijo}");
            Console.WriteLine($"Bonificación Docente de Contrato Fijo: {bonificacionDocenteContratoFijo}");

            // Instanciación de un Empleado Administrativo
            EmpleadoAdministrativo empleadoAdministrativo = new EmpleadoAdministrativo("Carlos", "Lopez", 3, "EmpleadoAdministrativo", 2500);
            int salarioEmpleadoAdministrativo = empleadoAdministrativo.CalcularSalario(0); // No se usa el parámetro horas
            int bonificacionEmpleadoAdministrativo = empleadoAdministrativo.CalcularBonificacion(false); // No alcanzó la meta
            Console.WriteLine($"Salario Empleado Administrativo: {salarioEmpleadoAdministrativo}");
            Console.WriteLine($"Bonificación Empleado Administrativo: {bonificacionEmpleadoAdministrativo}");
        }
    }
}
