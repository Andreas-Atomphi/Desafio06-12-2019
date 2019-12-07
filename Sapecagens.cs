class BananaCalculator {
    private double banana;
    private double guaranaJesus;
    private string dollyGuarana;
    private void calcular() {
        try {
            banana = Convert.ToDouble(txtBANANA.Text);
            guaranaJesus = Math.Sqrt(banana);
            dollyGuarana = Convert.ToString(guarana_jesus);
            txtResultado.Text = dolly_guarana;
        }
        catch (FormatException) {
            MessageBox.Show("Formatação Errada.");
        }
    }
}