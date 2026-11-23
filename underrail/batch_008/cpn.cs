using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EED RID: 7917
[ayj("Hemopsychosis")]
public sealed class cpn : c0z
{
	// Token: 0x0600B4A5 RID: 46245 RVA: 0x00408BB8 File Offset: 0x00406DB8
	public override string y8()
	{
		return "Гемопсихоз";
	}

	// Token: 0x0600B4A6 RID: 46246 RVA: 0x00408BC0 File Offset: 0x00406DC0
	public override string os()
	{
		return "Hemopsychosis";
	}

	// Token: 0x0600B4A7 RID: 46247 RVA: 0x00408BC8 File Offset: 0x00406DC8
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B4A8 RID: 46248 RVA: 0x00408BCC File Offset: 0x00406DCC
	public override int e8()
	{
		return 4;
	}

	// Token: 0x0600B4A9 RID: 46249 RVA: 0x00408BD0 File Offset: 0x00406DD0
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.g
		};
	}

	// Token: 0x0600B4AA RID: 46250 RVA: 0x00408BE4 File Offset: 0x00406DE4
	public cpn()
	{
		this.b = new List<string>();
		this.b.Add("SA.Hemopsychosis");
	}

	// Token: 0x0600B4AB RID: 46251 RVA: 0x00408C08 File Offset: 0x00406E08
	public override string bm(cnm A_0)
	{
		return "Status.Hemopsychosis";
	}

	// Token: 0x0600B4AC RID: 46252 RVA: 0x00408C10 File Offset: 0x00406E10
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B4AD RID: 46253 RVA: 0x00408C14 File Offset: 0x00406E14
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAbilities/Hemopsychosis");
	}

	// Token: 0x0600B4AE RID: 46254 RVA: 0x00408C24 File Offset: 0x00406E24
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		double num = (double)c.a;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= (double)A_0.b8().GetSpecializationValue<d65>(true) * d65.a;
		}
		return new List<cfd>
		{
			new cfd("SA.Hemopsychosis", (int)(num * (double)d0u.b), false, false)
		};
	}

	// Token: 0x0600B4AF RID: 46255 RVA: 0x00408C80 File Offset: 0x00406E80
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600B4B0 RID: 46256 RVA: 0x00408C88 File Offset: 0x00406E88
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B4B1 RID: 46257 RVA: 0x00408C8C File Offset: 0x00406E8C
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B4B2 RID: 46258 RVA: 0x00408C94 File Offset: 0x00406E94
	public static float a(eoj A_0, int A_1)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return (float)Convert.ToInt32((double)A_1 * (1.0 - (double)A_0.b8().GetSpecializationValue<b70>(true) * b70.a));
		}
		return (float)A_1;
	}

	// Token: 0x040041EA RID: 16874
	private new const string a = "SA.Hemopsychosis";

	// Token: 0x040041EB RID: 16875
	private List<string> b;
}
