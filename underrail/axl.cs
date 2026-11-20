using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F50 RID: 8016
[ayj("RefuelFireplace")]
public sealed class axl : c0r
{
	// Token: 0x0600BB2B RID: 47915 RVA: 0x00414504 File Offset: 0x00412704
	public override string y8()
	{
		return "Заправить огнём";
	}

	// Token: 0x0600BB2C RID: 47916 RVA: 0x0041450C File Offset: 0x0041270C
	public override string os()
	{
		return "RefuelFireplace";
	}

	// Token: 0x0600BB2D RID: 47917 RVA: 0x00414514 File Offset: 0x00412714
	public override string c1()
	{
		return "Заправляет";
	}

	// Token: 0x0600BB2E RID: 47918 RVA: 0x0041451C File Offset: 0x0041271C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Fireplace;
	}

	// Token: 0x0600BB2F RID: 47919 RVA: 0x00414520 File Offset: 0x00412720
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600BB30 RID: 47920 RVA: 0x00414524 File Offset: 0x00412724
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BB31 RID: 47921 RVA: 0x00414538 File Offset: 0x00412738
	public axl()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600BB32 RID: 47922 RVA: 0x0041454C File Offset: 0x0041274C
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BB33 RID: 47923 RVA: 0x00414554 File Offset: 0x00412754
	public override string bp(cnm A_0)
	{
		return qv.b("Items\\Utilities/RefuelFireplace");
	}

	// Token: 0x0600BB34 RID: 47924 RVA: 0x00414560 File Offset: 0x00412760
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BB35 RID: 47925 RVA: 0x00414564 File Offset: 0x00412764
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600BB36 RID: 47926 RVA: 0x0041456C File Offset: 0x0041276C
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600BB37 RID: 47927 RVA: 0x00414574 File Offset: 0x00412774
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600BB38 RID: 47928 RVA: 0x0041457C File Offset: 0x0041277C
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600BB39 RID: 47929 RVA: 0x00414584 File Offset: 0x00412784
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600BB3A RID: 47930 RVA: 0x00414588 File Offset: 0x00412788
	protected override int hi(cnm A_0)
	{
		return 25;
	}

	// Token: 0x040043E2 RID: 17378
	private new List<string> a;
}
