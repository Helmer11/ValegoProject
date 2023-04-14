using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValegoProject.Interfaces;
using ValegoProject.Models;

namespace ValegoProject.Services
{
    public class NetworkService : INetwork
    {
        private readonly ValegoDbContext context;
        private readonly NetWork net;

        public NetworkService(ValegoDbContext _context)
        {
            this.context = _context;
            net = new NetWork();
        }

        public string setNetworks(NetWork red)
        {
            try
            {
                using (var db = this.context)
                {

                    net.NetworkName = red.NetworkName;
                    net.Name = red.Name;
                    net.Currency = red.Currency;
                    net.NetworkSymbol = red.NetworkSymbol;
                    net.TransactionExplorer = red.TransactionExplorer;
                    net.TokenExplorer = red.TokenExplorer;
                    net.DepositConfirmations = red.DepositConfirmations;
                    net.Enabled = red.Enabled;
                    db.NetWorks.Add(red);
                    db.SaveChanges();
                }
               

                return "Se Registro correctamente el network";
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

      
    }
}
