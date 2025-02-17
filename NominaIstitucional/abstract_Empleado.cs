public class Empleado { 
    //declaracion de atributos
    private string nombre;
    private string apellido;
    private int codigo;
    private string tipoEmpleado;
    private int pago;
    //constructor
    public Empleado(string nombre, string apellido, int codigo, string TipoEmpleado, int pago)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.codigo = codigo;
        this.tipoEmpleado = TipoEmpleado;
        this.pago = pago;
    }
    //propiedadas para acseso a los atributos
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Codigo { get; set; }
    public string TipoEmpleado { get; set; }
    public int Pago { get; set; }
    //metodo para calcular el salario de los empleados
    protected virtual int CalcularSalario(int horas, string tipo)
    {
        if (tipo == "hora")
        {
            return horas * 800;
        }
        else if (tipo == "fijo")
        {
            return Pago;
        }
        return 0;
    }

    //metodo para calcular bonificaciones
    public int CalcularBonificacion(bool alcanzoMeta)
    {
        return alcanzoMeta ? Pago : Pago / 2;
    }
}
