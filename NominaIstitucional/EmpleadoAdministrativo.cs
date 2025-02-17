namespace NominaIstitucional {
    public class EmpleadoAdministrativo : Empleado {

        public EmpleadoAdministrativo(string nombre, string apellido, int codigo, string TipoEmpleado, int Pago) :
            base(nombre, apellido, codigo, TipoEmpleado, Pago)
        {
        }

        public int CalcularSalario(int horas)
        {
           return base.CalcularSalario(horas, "fijo");
        }

        public int CalcularBonificacion(bool alcanzoMeta)
        {
            return base.CalcularBonificacion(alcanzoMeta);
        }
    }
}
