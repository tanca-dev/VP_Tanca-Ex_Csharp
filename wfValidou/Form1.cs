using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wfValidou
{
    public partial class Form1 : Form
    {
        //Função que Inicializa Serviço
        //[DllImport("VP_v3_x64.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X64
        [DllImport("VP_v3.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X86
        public static extern void vInitialize();

        //Função que Inicializa Servidor
        //[DllImport("VP_v3_x64.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X64
        [DllImport("VP_v3.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X86
        public static extern int tc_startserver();

        //Função que Identifica Terminais Conectados ao Servidor
        //[DllImport("VP_v3_x64.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X64
        [DllImport("VP_v3.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X86
        public static unsafe extern bool bConnected(out uint ID_IP, out ushort Porta);

        //Função que Identifica Terminais Desconectados do Servidor
        //[DllImport("VP_v3_x64.dll")] //----> X64
        [DllImport("VP_v3.dll")] //----> X86
        public static extern unsafe bool bDisconnected(out uint ID_IP, out ushort ID_Socket);

        //Função que Desconecta dado Terminal
        //[DllImport("VP_v3_x64.dll")] //----> X64
        [DllImport("VP_v3.dll")] //----> X86
        public static extern unsafe bool bCloseTerminal(uint ID_IP, ushort ID_Socket);

        //Formatação de Valores
        //[DllImport("VP_v3_x64.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X64
        [DllImport("VP_v3.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X86
        public static extern unsafe IntPtr Inet_NtoA(uint ID_IP);

        //[DllImport("VP_v3_x64.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X64
        [DllImport("VP_v3.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X86
        public static extern unsafe uint Inet_Addr(IntPtr sIP);

        //Função que busca a versão da DLL
        //[DllImport("VP_v3_x64.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X64
        [DllImport("VP_v3.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X86
        static extern IntPtr dll_version();

        //Função para enviar mensagem para as linhas 1 e 2 do terminal
        //[DllImport("VP_v3_x64.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X64
        [DllImport("VP_v3.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X86
        public static extern unsafe bool bSendDisplayMsg(uint ID_IP, IntPtr Linha1, IntPtr Linha2, int Tempo);

        //Função usada periodicamente para identificar se houve solicitação de pesquisa de código de barras pendente. 
        //Caso haja, retornará o código de barras (ponteiro string), o endereço IP e a porta do terminal solicitante;
        //[DllImport("VP_v3_x64.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X64
        [DllImport("VP_v3.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X86
        public static extern unsafe IntPtr bReceiveBarcode(out uint ID_IP, out ushort ID_Socket, out int Nbr);

        //Função usada para Informar a aplicação que o terminal solicitante recebeu a mensagem;
        //[DllImport("VP_v3_x64.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X64
        [DllImport("VP_v3.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X86
        public static extern unsafe bool bSendProdNotFound(uint ID_IP);

        //Envia para a primeira e segunda linha do display do terminal solicitante o nome e o preço do produto pesquisado;
        //[DllImport("VP_v3_x64.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X64
        [DllImport("VP_v3.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X86
        public static extern unsafe bool bSendProdPrice(UInt32 IP, IntPtr Prod, IntPtr Valor);

        //Função que Finaliza Serviço
        //[DllImport("VP_v3_x64.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X64
        [DllImport("VP_v3.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)] //----> X86
        public static extern bool bTerminate();

        //Neste Exemplo você assistirá o uso de uma variavel fixa para representar o valor do terminal identificado como conectado
        //Mas, na prática, você deverá desenvolver um forma de controle para essa informação, para poder utilizar e fazer referência 
        //ao terminais conectado, você pode utilizar meios como tabela, grid, etc
        uint IpTerminal = 0;

        public Form1()
        {
           InitializeComponent();
            //Solicitando o serviço
            Servico();
        }
        private void Servico()
        {
            vInitialize();
            LbMensagens.Items.Add("Serviço Inicializado!");

            if (tc_startserver() == 1)
            {
                LbMensagens.Items.Add("Servidor a todo vapor!");

                Timer.Interval = 10000;
                Timer.Tick += new EventHandler(Timer_Tick);
                Timer.Enabled = true;
            }
            else
            {
                LbMensagens.Items.Add("Servidor Não inicializado!");
            }
            
        }

        private void BtnValida_Click(object sender, EventArgs e)
        {
            IntPtr dados = dll_version();
            
            //A maneira como se pretende apresentar essa informação pode ser tratada, estéticamente caso veja necessidade
            LbMensagens.Items.Add("Versão da DLL é  " + dados);
                        
        }
        private void Timer_Tick(object Sender, EventArgs e)
        {

            LbMensagens.Items.Add(DateTime.Now.ToString());
            if (bConnected(out uint Term, out ushort Porta))
            {
                LbMensagens.Items.Add("Novo Terminal " + Term + " conectado na porta " + Porta);

                IpTerminal = Term;
            }
            else
            {
                //Você não precisa desenvolver esse tipo de informação, essa mensagem serve apenas como referência
                LbMensagens.Items.Add("Não conectou novo Terminal");
            }

            TmTerminal.Interval = 10000;
            TmTerminal.Tick += new EventHandler(TmTerminal_Tick);
            TmTerminal.Enabled = true;
            Timer.Enabled = false;
        }
        private void TmTerminal_Tick(object Sender, EventArgs e)
        {
            UInt32 CodBarras = 123;
            UInt32 Teste = 0;

            //Será necessário que você desenvolva um mecanismo de comunicação entre sua aplicação e sua base de dados
            //Os valores fixos servem apenas como referencia
            string ProdDados = "LIMAO";
            string ValorDados = "2,00";

            IntPtr Cod = Marshal.StringToHGlobalAnsi("0");
            IntPtr Prod = Marshal.StringToHGlobalAnsi(ProdDados);
            IntPtr Valor = Marshal.StringToHGlobalAnsi(ValorDados);

            try
            {
                Cod = bReceiveBarcode(out uint Term, out ushort Porta, out int QtCod);

                string CodBar = Marshal.PtrToStringAnsi(Cod);

                try
                {
                    if (Term > 0)
                    {
                        if (CodBarras == Convert.ToInt32(CodBar))
                        {
                            //Você não pode montar o retorno de dados conforme a sua estratégia
                            LbMensagens.Items.Add("O produto " + CodBar + "existe? By: " + Term + " ");

                            _ = bSendProdPrice(Term, Prod, Valor);
                            LbMensagens.Items.Add("Sim " + Term);
                        }
                        else
                        {
                            LbMensagens.Items.Add("O produto " + CodBar + "existe? By: " + Term + " ");

                            _ = bSendProdNotFound(Term);

                            LbMensagens.Items.Add("Não existe");

                            /* Outra maneira de fazer
                            Prod = Marshal.StringToHGlobalAnsi("NAO EXISTENTE");
                            Valor = Marshal.StringToHGlobalAnsi("0");

                            _ = bSendProdPrice(Term, Prod, Valor);*/
                        }
                    }
                }
                catch
                {
                    if (Term > 0)
                    {

                        if (CodBarras == Teste)
                        {
                            LbMensagens.Items.Add("O produto " + CodBar + "existe? By: " + Term + " ");

                            _ = bSendProdPrice(Term, Prod, Valor);
                        }
                        else
                        {
                            LbMensagens.Items.Add("O produto " + CodBar + "existe? By: " + Term + " ");

                            _ = bSendProdNotFound(Term);

                            LbMensagens.Items.Add("Não existe");
                        }
                    }
                }
            }
            catch
            {
                LbMensagens.Items.Add("Aguardando Pesquisa.");
            }
            TmTerminal.Enabled = false;
            Timer.Enabled = true;
        }

        private void BtEnviar_Click(object sender, EventArgs e)
        {
            LbTerminal.Items.Add(IpTerminal);

            if (TbLinha1.Text != "" && TbLinha2.Text != "" && TbTempo.Text != "")
            {
                int Tempo = Convert.ToInt32(TbTempo.Text.Trim());
                string aux = TbLinha1.Text.Trim();
                string aux1 = TbLinha2.Text.Trim();

                IntPtr Linha1 = Marshal.StringToHGlobalAnsi(aux);
                IntPtr Linha2 = Marshal.StringToHGlobalAnsi(aux1);

                try
                {
                    if (bSendDisplayMsg(IpTerminal, Linha1, Linha2, Tempo) == true)
                    {
                        LbMensagens.Items.Add("Mensagem Enviada");
                    }
                    else
                    {
                        LbMensagens.Items.Add("RETORNO FALSO");
                    }
                }
                catch
                {
                    LbMensagens.Items.Add("Dados invalidos");
                }
            }
            else
            {
                LbMensagens.Items.Add("Preencha os campos");
            }

            TbLinha1.Text = "";
            TbLinha2.Text = "";
            TbTempo.Text = "";
            LbTerminal.Items.Clear();
        }

        private void TbTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
