using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EFC RID: 7932
[ayj("UncannyDodge")]
public sealed class amv : c0z
{
	// Token: 0x0600B589 RID: 46473 RVA: 0x00409BE8 File Offset: 0x00407DE8
	public override string y8()
	{
		return "Невероятное уклонение";
	}

	// Token: 0x0600B58A RID: 46474 RVA: 0x00409BF0 File Offset: 0x00407DF0
	public override string os()
	{
		return "UncannyDodge";
	}

	// Token: 0x0600B58B RID: 46475 RVA: 0x00409BF8 File Offset: 0x00407DF8
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B58C RID: 46476 RVA: 0x00409BFC File Offset: 0x00407DFC
	public override int e8()
	{
		return 3;
	}

	// Token: 0x0600B58D RID: 46477 RVA: 0x00409C00 File Offset: 0x00407E00
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x0600B58E RID: 46478 RVA: 0x00409C14 File Offset: 0x00407E14
	public amv()
	{
		this.c = new List<string>();
		this.c.Add("SA.UncannyDodge");
	}

	// Token: 0x0600B58F RID: 46479 RVA: 0x00409C38 File Offset: 0x00407E38
	public override string bm(cnm A_0)
	{
		return "UncannyDodge";
	}

	// Token: 0x0600B590 RID: 46480 RVA: 0x00409C40 File Offset: 0x00407E40
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B591 RID: 46481 RVA: 0x00409C44 File Offset: 0x00407E44
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/UncannyDodge", new object[]
		{
			amv.a(A_0)
		});
	}

	// Token: 0x0600B592 RID: 46482 RVA: 0x00409C64 File Offset: 0x00407E64
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.UncannyDodge", amv.b * d0u.b, false, false)
		};
	}

	// Token: 0x0600B593 RID: 46483 RVA: 0x00409C88 File Offset: 0x00407E88
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null) && !A_0.b8().SpecialStates.b;
	}

	// Token: 0x0600B594 RID: 46484 RVA: 0x00409CC0 File Offset: 0x00407EC0
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B595 RID: 46485 RVA: 0x00409CC8 File Offset: 0x00407EC8
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B596 RID: 46486 RVA: 0x00409CCC File Offset: 0x00407ECC
	public new static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return bov.a + A_0.b8().Defense.v() / (bov.b - A_0.b8().GetSpecializationValue<ej6>(true) * ej6.a);
		}
		return bov.a;
	}

	// Token: 0x0600B597 RID: 46487 RVA: 0x00409D20 File Offset: 0x00407F20
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400421F RID: 16927
	private new const string a = "SA.UncannyDodge";

	// Token: 0x04004220 RID: 16928
	public static readonly int b = 5;

	// Token: 0x04004221 RID: 16929
	private List<string> c;
}
