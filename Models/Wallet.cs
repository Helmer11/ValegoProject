using System;
using System.Collections.Generic;

namespace ValegoProject.Models;

public partial class Wallet
{
    public int Id { get; set; }

    public string Asset { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string MajorCurrency { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string CuurencyType { get; set; } = null!;

    public byte Scala { get; set; }

    public bool Enable { get; set; }

    public bool? IsMarginCurrency { get; set; }

    public int MinDepositAmount { get; set; }

    public int MinWithdrawalAmount { get; set; }

    public int MaxWithdrawalAmount { get; set; }

    public int NetworksId { get; set; }

    public virtual Rede Networks { get; set; } = null!;
}
