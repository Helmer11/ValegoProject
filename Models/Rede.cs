using System;
using System.Collections.Generic;

namespace ValegoProject.Models;

public partial class Rede
{
    public int Id { get; set; }

    public string Asset { get; set; } = null!;

    public string? TokenAddress { get; set; }

    public bool DepositEnabled { get; set; }

    public bool WithdrawalEnabled { get; set; }

    public int WithdrawalFee { get; set; }

    public int MinFee { get; set; }

    public int MaxFee { get; set; }

    public virtual ICollection<Wallet> Wallets { get; set; } = new List<Wallet>();
}
