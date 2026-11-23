using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F3A RID: 7994
[ayj("DetonateEpioneLabCharges")]
public sealed class d2q : m0
{
	// Token: 0x0600B9D3 RID: 47571 RVA: 0x004126EC File Offset: 0x004108EC
	public override string y8()
	{
		return "DetonateEpioneLabCharges";
	}

	// Token: 0x0600B9D4 RID: 47572 RVA: 0x004126F4 File Offset: 0x004108F4
	public override string os()
	{
		return "DetonateEpioneLabCharges";
	}

	// Token: 0x0600B9D5 RID: 47573 RVA: 0x004126FC File Offset: 0x004108FC
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B9D6 RID: 47574 RVA: 0x00412700 File Offset: 0x00410900
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600B9D7 RID: 47575 RVA: 0x00412704 File Offset: 0x00410904
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600B9D8 RID: 47576 RVA: 0x00412718 File Offset: 0x00410918
	public override string c1()
	{
		return "Взрывает";
	}

	// Token: 0x0600B9D9 RID: 47577 RVA: 0x00412720 File Offset: 0x00410920
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600B9DA RID: 47578 RVA: 0x00412724 File Offset: 0x00410924
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B9DB RID: 47579 RVA: 0x0041272C File Offset: 0x0041092C
	public d2q()
	{
		this.c = new List<string>();
		this.c.Add("DetonateEpioneLabCharges");
	}

	// Token: 0x0600B9DC RID: 47580 RVA: 0x00412750 File Offset: 0x00410950
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600B9DD RID: 47581 RVA: 0x00412754 File Offset: 0x00410954
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B9DE RID: 47582 RVA: 0x00412758 File Offset: 0x00410958
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B9DF RID: 47583 RVA: 0x0041275C File Offset: 0x0041095C
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B9E0 RID: 47584 RVA: 0x00412764 File Offset: 0x00410964
	public override string bp(cnm A_0)
	{
		return qv.b("Items\\Custom/DetonateEpioneLabCharges");
	}

	// Token: 0x0600B9E1 RID: 47585 RVA: 0x00412770 File Offset: 0x00410970
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("DetonateEpioneLabCharges", d2q.b, false, false)
		};
	}

	// Token: 0x0600B9E2 RID: 47586 RVA: 0x00412790 File Offset: 0x00410990
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B9E3 RID: 47587 RVA: 0x00412794 File Offset: 0x00410994
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B9E4 RID: 47588 RVA: 0x00412798 File Offset: 0x00410998
	protected override int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004394 RID: 17300
	private new const string a = "DetonateEpioneLabCharges";

	// Token: 0x04004395 RID: 17301
	public static readonly int b = 1000;

	// Token: 0x04004396 RID: 17302
	private List<string> c;
}
