namespace Fase2_Aula13CadastroDeUsuarios
{
    public partial class Form1 : Form
    {

        List<Pessoa> listasPessoas = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
        }
        List<string> nome = new List<string>();

        public void atualizarInterface()
        {
            listView1.Clear();
            for(int i=0; i <listasPessoas.Count; i++)
            {
                listView1.Items.Add(listasPessoas[i].nome);
                listView1.Items.Add(listasPessoas[i].idade.ToString());
                listView1.Items.Add(listasPessoas[i].rua);
                listView1.Items.Add(listasPessoas[i].cidade);



            }
            
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome =txtNome.Text;
            int idade =int.Parse(txtIdade.Text);
            string rua = txtEndereco.Text;
            string cidade = txtCidade.Text;

            Pessoa pessoa = new Pessoa(nome, idade, rua, cidade);

            listasPessoas.Add(pessoa);

            atualizarInterface();




        }
    }
}