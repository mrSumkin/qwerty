using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BAF RID: 7087
[dgg("regenerativeMixture")]
public sealed class c78 : cwp
{
	// Token: 0x060099FD RID: 39421 RVA: 0x003BFE08 File Offset: 0x003BE008
	public override string bt()
	{
		return "莓Регенеративная смесь";
	}

	// Token: 0x060099FE RID: 39422 RVA: 0x003BFE10 File Offset: 0x003BE010
	public override string bu()
	{
		return "regenerativeMixture";
	}

	// Token: 0x060099FF RID: 39423 RVA: 0x003BFE18 File Offset: 0x003BE018
	public override cr1 bv()
	{
		return cr1.e;
	}

	// Token: 0x06009A00 RID: 39424 RVA: 0x003BFE1C File Offset: 0x003BE01C
	public override int dq()
	{
		return 1;
	}

	// Token: 0x06009A01 RID: 39425 RVA: 0x003BFE20 File Offset: 0x003BE020
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009A02 RID: 39426 RVA: 0x003BFE24 File Offset: 0x003BE024
	public c78()
	{
		base.Slots.Add("biofusiveScoby", new cgo(new eh0("biofusiveScoby", 57), "Биоактивная колония", false, 1, 0.1f, false, false, null));
		base.Slots.Add("blood", new cgo(new eh0("blood", 55), "Кровь", false, 2, 0.1f, false, false, null));
		base.Slots.Add("cleanBlastema", new cgo(new eh0("cleanBlastema", 68), "Очищенная бластема", false, 1, 0.1f, false, false, null));
		base.Slots.Add("macrophageFluid", new cgo(new eh0("macrophageFluid", 55), "Взвесь макрофагов", false, 1, 0.1f, false, false, null));
		base.Slots.Add("ampule", new cgo(new c6s(new ms[]
		{
			ms.f
		}, 5), "Ампула", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009A03 RID: 39427 RVA: 0x003BFF2C File Offset: 0x003BE12C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\RegenerativeMixture");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}
}
