namespace _2014118209_ENT
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }

        public string DNI { get; set; }

        public Empleado()
        {

        }

        public Empleado(string dni)
        {
            DNI = dni;
        }
    }
}