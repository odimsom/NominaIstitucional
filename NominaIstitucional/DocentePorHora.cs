namespace NominaIstitucional {
    public class DocentePorHora : Empleado {

        public DocentePorHora(string nombre, string apellido, int codigo, string TipoEmpleado, int Pago) :
            base(nombre, apellido, codigo, TipoEmpleado, Pago)
        {
        }

        public int CalcularSalario(int horas)
        {
           return base.CalcularSalario(horas, "hora");
        }
    }
}
