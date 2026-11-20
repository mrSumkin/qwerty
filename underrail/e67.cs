using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EEF RID: 7919
[ayj("PsionicMania")]
public sealed class e67 : c0z
{
	// Token: 0x0600B4C5 RID: 46277 RVA: 0x00408E1C File Offset: 0x0040701C
	public override string y8()
	{
		return "Пси-мания";
	}

	// Token: 0x0600B4C6 RID: 46278 RVA: 0x00408E24 File Offset: 0x00407024
	public override string os()
	{
		return "PsionicMania";
	}

	// Token: 0x0600B4C7 RID: 46279 RVA: 0x00408E2C File Offset: 0x0040702C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B4C8 RID: 46280 RVA: 0x00408E30 File Offset: 0x00407030
	public override int e8()
	{
		return 4;
	}

	// Token: 0x0600B4C9 RID: 46281 RVA: 0x00408E34 File Offset: 0x00407034
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.g
		};
	}

	// Token: 0x0600B4CA RID: 46282 RVA: 0x00408E48 File Offset: 0x00407048
	public e67()
	{
		this.b = new List<string>();
		this.b.Add("SA.PsionicMania");
	}

	// Token: 0x0600B4CB RID: 46283 RVA: 0x00408E6C File Offset: 0x0040706C
	public override string bm(cnm A_0)
	{
		return "PsionicMania";
	}

	// Token: 0x0600B4CC RID: 46284 RVA: 0x00408E74 File Offset: 0x00407074
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B4CD RID: 46285 RVA: 0x00408E78 File Offset: 0x00407078
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/PsionicMania", new object[]
		{
			(int)(e67.a(A_0) * 100.0)
		});
	}

	// Token: 0x0600B4CE RID: 46286 RVA: 0x00408EA8 File Offset: 0x004070A8
	public new static double a(cnm A_0)
	{
		double num = d11.b;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= (double)A_0.b8().GetSpecializationValue<bwn>(true) * bwn.a;
		}
		return Math.Round(num, 2);
	}

	// Token: 0x0600B4CF RID: 46287 RVA: 0x00408EEC File Offset: 0x004070EC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		double num = (double)d11.c;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= (double)A_0.b8().GetSpecializationValue<ef3>(true) * ef3.a;
		}
		return new List<cfd>
		{
			new cfd("SA.PsionicMania", (int)(num * (double)d0u.b), false, false)
		};
	}

	// Token: 0x0600B4D0 RID: 46288 RVA: 0x00408F48 File Offset: 0x00407148
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600B4D1 RID: 46289 RVA: 0x00408F50 File Offset: 0x00407150
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B4D2 RID: 46290 RVA: 0x00408F54 File Offset: 0x00407154
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x040041F3 RID: 16883
	private new const string a = "SA.PsionicMania";

	// Token: 0x040041F4 RID: 16884
	private List<string> b;
}
