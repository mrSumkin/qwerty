using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B9B RID: 7067
[dgg("vehicleRepairKit")]
public sealed class asn : cwp
{
	// Token: 0x0600996D RID: 39277 RVA: 0x003BC4C0 File Offset: 0x003BA6C0
	public override string bt()
	{
		return "茆Ремкомплект для транспорта";
	}

	// Token: 0x0600996E RID: 39278 RVA: 0x003BC4C8 File Offset: 0x003BA6C8
	public override string bu()
	{
		return "vehicleRepairKit";
	}

	// Token: 0x0600996F RID: 39279 RVA: 0x003BC4D0 File Offset: 0x003BA6D0
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009970 RID: 39280 RVA: 0x003BC4D4 File Offset: 0x003BA6D4
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Devices;
	}

	// Token: 0x06009971 RID: 39281 RVA: 0x003BC4DC File Offset: 0x003BA6DC
	public asn()
	{
		base.Slots.Add("mech_scraps", new cgo(new eh0(new string[]
		{
			"metalScraps"
		}, 86), "Металлолом", false, 150, 0.1f, false, false, null));
		base.Slots.Add("electronic_scraps", new cgo(new eh0(new string[]
		{
			"electronicScraps"
		}, 105), "Электронные компоненты", false, 75, 0.1f, false, false, null));
	}

	// Token: 0x06009972 RID: 39282 RVA: 0x003BC568 File Offset: 0x003BA768
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<ebz>("Devices\\VehicleRepairKit");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}

	// Token: 0x06009973 RID: 39283 RVA: 0x003BC5A0 File Offset: 0x003BA7A0
	protected override Dictionary<string, int> gk(coh A_0)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		if (A_0 != null && A_0.Definition != null)
		{
			if (A_0.Definition.a5() == "metalScraps")
			{
				dictionary["Mechanics"] = 70;
			}
			else if (A_0.Definition.a5() == "electronicScraps")
			{
				dictionary["Electronics"] = 40;
			}
		}
		return dictionary;
	}
}
