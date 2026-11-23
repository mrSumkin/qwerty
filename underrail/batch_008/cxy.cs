using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F37 RID: 7991
[ayj("SearchSkerderCorpse")]
public sealed class cxy : m0
{
	// Token: 0x0600B99E RID: 47518 RVA: 0x00412500 File Offset: 0x00410700
	public override string y8()
	{
		return "SearchSkerderCorpse";
	}

	// Token: 0x0600B99F RID: 47519 RVA: 0x00412508 File Offset: 0x00410708
	public override string os()
	{
		return "SearchSkerderCorpse";
	}

	// Token: 0x0600B9A0 RID: 47520 RVA: 0x00412510 File Offset: 0x00410710
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B9A1 RID: 47521 RVA: 0x00412514 File Offset: 0x00410714
	public override bool cz()
	{
		return false;
	}

	// Token: 0x0600B9A2 RID: 47522 RVA: 0x00412518 File Offset: 0x00410718
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600B9A3 RID: 47523 RVA: 0x0041252C File Offset: 0x0041072C
	public override string c1()
	{
		return "Ищет";
	}

	// Token: 0x0600B9A4 RID: 47524 RVA: 0x00412534 File Offset: 0x00410734
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600B9A5 RID: 47525 RVA: 0x00412538 File Offset: 0x00410738
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600B9A6 RID: 47526 RVA: 0x00412540 File Offset: 0x00410740
	public cxy()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600B9A7 RID: 47527 RVA: 0x00412554 File Offset: 0x00410754
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600B9A8 RID: 47528 RVA: 0x00412558 File Offset: 0x00410758
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B9A9 RID: 47529 RVA: 0x0041255C File Offset: 0x0041075C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B9AA RID: 47530 RVA: 0x00412560 File Offset: 0x00410760
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B9AB RID: 47531 RVA: 0x00412568 File Offset: 0x00410768
	public override string bp(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B9AC RID: 47532 RVA: 0x00412570 File Offset: 0x00410770
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B9AD RID: 47533 RVA: 0x00412578 File Offset: 0x00410778
	public override dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x0600B9AE RID: 47534 RVA: 0x0041257C File Offset: 0x0041077C
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B9AF RID: 47535 RVA: 0x00412580 File Offset: 0x00410780
	protected override int br(cnm A_0)
	{
		double num = 1.0;
		if (A_0 != null && A_0.b8() != null)
		{
			num = Math.Min(0.5, 6.0 / (double)A_0.b8().BaseAbilities.Dexterity);
		}
		return Convert.ToInt32(15000.0 * num);
	}

	// Token: 0x04004391 RID: 17297
	private new List<string> a;
}
