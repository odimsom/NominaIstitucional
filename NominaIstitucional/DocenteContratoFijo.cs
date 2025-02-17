namespace NominaIstitucional {
    public class DocenteContratoFijo : Empleado {

        public DocenteContratoFijo(string nombre, string apellido, int codigo, string TipoEmpleado, int Pago) :
            base(nombre, apellido, codigo, TipoEmpleado, Pago)
        {
        }

        public int CalcularSalario()
        {
           return base.CalcularSalario(0, "fijo");
        }

        public int CalcularBonificacion(bool alcanzoMeta)
        {
            return base.CalcularBonificacion(alcanzoMeta);
        }
    }
}
