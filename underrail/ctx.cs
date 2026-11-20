using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EFD RID: 7933
[ayj("SiphonBlood")]
public sealed class ctx : c0z
{
	// Token: 0x0600B599 RID: 46489 RVA: 0x00409D2C File Offset: 0x00407F2C
	public override string y8()
	{
		return "Отсос крови";
	}

	// Token: 0x0600B59A RID: 46490 RVA: 0x00409D34 File Offset: 0x00407F34
	public override string os()
	{
		return "SiphonBlood";
	}

	// Token: 0x0600B59B RID: 46491 RVA: 0x00409D3C File Offset: 0x00407F3C
	public override string c1()
	{
		return "Присасывается";
	}

	// Token: 0x0600B59C RID: 46492 RVA: 0x00409D44 File Offset: 0x00407F44
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B59D RID: 46493 RVA: 0x00409D48 File Offset: 0x00407F48
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B59E RID: 46494 RVA: 0x00409D4C File Offset: 0x00407F4C
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.c,
			e = c0e.h
		};
	}

	// Token: 0x0600B59F RID: 46495 RVA: 0x00409D6C File Offset: 0x00407F6C
	public ctx()
	{
		this.c = new List<string>();
		this.c.Add("SA.SiphonBlood");
	}

	// Token: 0x0600B5A0 RID: 46496 RVA: 0x00409D90 File Offset: 0x00407F90
	public override string bm(cnm A_0)
	{
		return "SpecialAttacks.0";
	}

	// Token: 0x0600B5A1 RID: 46497 RVA: 0x00409D98 File Offset: 0x00407F98
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B5A2 RID: 46498 RVA: 0x00409D9C File Offset: 0x00407F9C
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B5A3 RID: 46499 RVA: 0x00409DA4 File Offset: 0x00407FA4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.SiphonBlood", ctx.b, false, false)
		};
	}

	// Token: 0x0600B5A4 RID: 46500 RVA: 0x00409DC4 File Offset: 0x00407FC4
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B5A5 RID: 46501 RVA: 0x00409DCC File Offset: 0x00407FCC
	public new static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return A_0.b8().Level * 2 - 4;
		}
		return 12;
	}

	// Token: 0x0600B5A6 RID: 46502 RVA: 0x00409DF4 File Offset: 0x00407FF4
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B5A7 RID: 46503 RVA: 0x00409DFC File Offset: 0x00407FFC
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600B5A8 RID: 46504 RVA: 0x00409E04 File Offset: 0x00408004
	protected override int hi(cnm A_0)
	{
		return 40;
	}

	// Token: 0x0600B5A9 RID: 46505 RVA: 0x00409E08 File Offset: 0x00408008
	protected override int ma(cnm A_0)
	{
		return 2500;
	}

	// Token: 0x0600B5AA RID: 46506 RVA: 0x00409E10 File Offset: 0x00408010
	protected override int mb(cnm A_0)
	{
		return 500;
	}

	// Token: 0x04004222 RID: 16930
	private new const string a = "SA.SiphonBlood";

	// Token: 0x04004223 RID: 16931
	public static readonly int b = d0u.b * 3;

	// Token: 0x04004224 RID: 16932
	private List<string> c;
}
