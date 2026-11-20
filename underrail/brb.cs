using System;
using System.Collections.Generic;

// Token: 0x020007E8 RID: 2024
public sealed class brb : el4
{
	// Token: 0x060032CF RID: 13007 RVA: 0x0013DAA0 File Offset: 0x0013BCA0
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x060032D0 RID: 13008 RVA: 0x0013DAAC File Offset: 0x0013BCAC
	public override string a4()
	{
		return "CC_RSC";
	}

	// Token: 0x060032D1 RID: 13009 RVA: 0x0013DAB4 File Offset: 0x0013BCB4
	public override string a5()
	{
		return "Core City Rays Shop Customer";
	}

	// Token: 0x060032D2 RID: 13010 RVA: 0x0013DABC File Offset: 0x0013BCBC
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_cc-dock2_shopOpen", new bool?(false)).Value)
		{
			return false;
		}
		cky cky = (A_0.ac() as bv9).abu(asp.di, asp.a);
		if (cky != null && cky.a == global::h.a)
		{
			return false;
		}
		List<string> list = new List<string>();
		list.Add("xpbl_junkJetFrame");
		list.Add("xpbl_scrapJetFrame");
		list.Add("xpbl_skimmerFrame");
		list.Add("xpbl_scooterFrame");
		list.Add("xpbl_freighterFrame");
		int num = 0;
		foreach (string a_ in list)
		{
			string name = aya.a(a_);
			dic classPropertyValue = A_0.r().GetClassPropertyValue<dic>(name);
			if (classPropertyValue != null && classPropertyValue.a() == "coreCity")
			{
				num++;
			}
		}
		return num >= 3 && base.e2(A_0, A_1, A_2);
	}

	// Token: 0x060032D3 RID: 13011 RVA: 0x0013DBE4 File Offset: 0x0013BDE4
	public override double ke()
	{
		return 0.15;
	}

	// Token: 0x060032D4 RID: 13012 RVA: 0x0013DBF0 File Offset: 0x0013BDF0
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060032D5 RID: 13013 RVA: 0x0013DBF4 File Offset: 0x0013BDF4
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x060032D6 RID: 13014 RVA: 0x0013DBFC File Offset: 0x0013BDFC
	public override bool fk()
	{
		return true;
	}

	// Token: 0x060032D7 RID: 13015 RVA: 0x0013DC00 File Offset: 0x0013BE00
	public override bool fl()
	{
		return true;
	}

	// Token: 0x060032D8 RID: 13016 RVA: 0x0013DC04 File Offset: 0x0013BE04
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(20.0));
	}

	// Token: 0x060032D9 RID: 13017 RVA: 0x0013DC1C File Offset: 0x0013BE1C
	public brb() : base(new string[]
	{
		ega.bf
	})
	{
	}

	// Token: 0x060032DA RID: 13018 RVA: 0x0013DC34 File Offset: 0x0013BE34
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
	}
}
