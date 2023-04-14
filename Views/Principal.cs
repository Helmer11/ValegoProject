using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Security.Policy;
using System.Text.Json;
using System.Windows.Forms;
using ValegoProject.ApiRest;
using ValegoProject.Interfaces;
using ValegoProject.Models;
using ValegoProject.Services;

namespace ValegoProject
{
    public partial class Principal : Form
    {
        private readonly RestApi api;
        private readonly NetWork red;
        private readonly ValegoDbContext context;
        private readonly INetwork _net;

        public Principal()
        {
            InitializeComponent();
            api = new RestApi();
            red = new NetWork();
            context = new ValegoDbContext();
            _net = new NetworkService(context);

        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            dynamic respuesta = api.Get("https://www.bitmex.com/api/v1/wallet/networks");

            dgvData.DataSource = respuesta;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<NetWork> mylista = new List<NetWork>();

              foreach(DataGridViewRow item in dgvData.Rows)
                {
                    if (item.IsNewRow == false)
                    {
                        red.NetworkName = item.Cells["network"].Value.ToString();
                        red.Name = item.Cells["Name"].Value.ToString();
                        red.Currency = item.Cells["currency"].Value.ToString();
                        red.NetworkSymbol = item.Cells["transactionExplorer"].Value.ToString();
                        red.TokenExplorer = item.Cells["tokenExplorer"].Value.ToString();
                        red.DepositConfirmations = Convert.ToByte(item.Cells["depositConfirmations"].Value.ToString());
                        red.Enabled = Convert.ToBoolean(item.Cells["enabled"].Value.ToString());
                        mylista.Add((NetWork)red);
                    }
                }
               
                var resultado = _net.setNetworks(mylista);

                //MessageBox.Show(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }
    }
}