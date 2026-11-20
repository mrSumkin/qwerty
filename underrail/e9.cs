using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F02 RID: 7938
[ayj("Premeditation")]
public sealed class e9 : c0z
{
	// Token: 0x0600B5EB RID: 46571 RVA: 0x0040A5E0 File Offset: 0x004087E0
	public override string y8()
	{
		return "Премедитация";
	}

	// Token: 0x0600B5EC RID: 46572 RVA: 0x0040A5E8 File Offset: 0x004087E8
	public override string os()
	{
		return "Premeditation";
	}

	// Token: 0x0600B5ED RID: 46573 RVA: 0x0040A5F0 File Offset: 0x004087F0
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B5EE RID: 46574 RVA: 0x0040A5F4 File Offset: 0x004087F4
	public override int e8()
	{
		return 3;
	}

	// Token: 0x0600B5EF RID: 46575 RVA: 0x0040A5F8 File Offset: 0x004087F8
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.g
		};
	}

	// Token: 0x0600B5F0 RID: 46576 RVA: 0x0040A60C File Offset: 0x0040880C
	public e9()
	{
		this.b = new List<string>();
		this.b.Add("SA.Premeditation");
	}

	// Token: 0x0600B5F1 RID: 46577 RVA: 0x0040A630 File Offset: 0x00408830
	public override string bm(cnm A_0)
	{
		return "Premeditation";
	}

	// Token: 0x0600B5F2 RID: 46578 RVA: 0x0040A638 File Offset: 0x00408838
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B5F3 RID: 46579 RVA: 0x0040A640 File Offset: 0x00408840
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/Premeditation", new object[]
		{
			(int)(e9.a(A_0) * 100.0),
			(int)(pv.e * 100.0),
			pv.a
		});
	}

	// Token: 0x0600B5F4 RID: 46580 RVA: 0x0040A69C File Offset: 0x0040889C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		int num = pv.b;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= (int)((double)A_0.b8().GetSpecializationValue<blc>(true) * blc.a * (double)d0u.b);
		}
		return new List<cfd>
		{
			new cfd("SA.Premeditation", num, false, false)
		};
	}

	// Token: 0x0600B5F5 RID: 46581 RVA: 0x0040A6F8 File Offset: 0x004088F8
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600B5F6 RID: 46582 RVA: 0x0040A700 File Offset: 0x00408900
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B5F7 RID: 46583 RVA: 0x0040A708 File Offset: 0x00408908
	public new static double a(cnm A_0)
	{
		double num = pv.d;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<ear>(true) * ear.a;
		}
		return num;
	}

	// Token: 0x0600B5F8 RID: 46584 RVA: 0x0040A744 File Offset: 0x00408944
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004237 RID: 16951
	private new const string a = "SA.Premeditation";

	// Token: 0x04004238 RID: 16952
	private List<string> b;
}
