namespace SISTotalControl.Entidades.ModelosBindeo
{
    public class PagarCuotaBindingModel
    {
        public int Id_agendamiento { get; set; }
        public decimal Valor_pagar { get; set; }
        public decimal Saldo_restante { get; set; }
    }
}
