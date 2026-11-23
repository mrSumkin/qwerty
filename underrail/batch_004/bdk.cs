using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EF6 RID: 7926
[ayj("AcidSpay")]
public sealed class bdk : c0z
{
	// Token: 0x0600B524 RID: 46372 RVA: 0x004092B8 File Offset: 0x004074B8
	public override string y8()
	{
		return "Кислотные брызги";
	}

	// Token: 0x0600B525 RID: 46373 RVA: 0x004092C0 File Offset: 0x004074C0
	public override string os()
	{
		return "AcidSpray";
	}

	// Token: 0x0600B526 RID: 46374 RVA: 0x004092C8 File Offset: 0x004074C8
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B527 RID: 46375 RVA: 0x004092CC File Offset: 0x004074CC
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B528 RID: 46376 RVA: 0x004092D0 File Offset: 0x004074D0
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.a,
			c = c0e.g
		};
	}

	// Token: 0x0600B529 RID: 46377 RVA: 0x004092F0 File Offset: 0x004074F0
	public bdk()
	{
		this.g = new List<string>();
		this.g.Add("SA.AcidSpay");
	}

	// Token: 0x0600B52A RID: 46378 RVA: 0x00409314 File Offset: 0x00407514
	public override string bm(cnm A_0)
	{
		if (c2h.a(A_0))
		{
			return "RustingAcidSpray";
		}
		return "AcidSpray";
	}

	// Token: 0x0600B52B RID: 46379 RVA: 0x0040932C File Offset: 0x0040752C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B52C RID: 46380 RVA: 0x00409334 File Offset: 0x00407534
	public override string bo(cnm A_0)
	{
		if (c2h.a(A_0))
		{
			return qv.a("SpecialAbilities/AcidSpray_Rusting", new object[]
			{
				bdk.e,
				bdk.a(A_0).a(true),
				ce.c,
				l4.a(ce.b, false),
				ce.a,
				Convert.ToInt32(d9b.a * 100.0)
			});
		}
		return qv.a("SpecialAbilities/AcidSpray", new object[]
		{
			bdk.e,
			bdk.a(A_0).a(true)
		});
	}

	// Token: 0x0600B52D RID: 46381 RVA: 0x004093F0 File Offset: 0x004075F0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.AcidSpay", bdk.b, false, false)
		};
	}

	// Token: 0x0600B52E RID: 46382 RVA: 0x00409410 File Offset: 0x00407610
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B52F RID: 46383 RVA: 0x00409418 File Offset: 0x00407618
	public static csk b(cnm A_0)
	{
		return euf.a(bdk.a(A_0), 1.0);
	}

	// Token: 0x0600B530 RID: 46384 RVA: 0x00409430 File Offset: 0x00407630
	public new static a1q a(cnm A_0)
	{
		a1q a1q = new a1q(DamageType.Acid, 5, 15);
		if (A_0 != null && A_0.b8() != null && A_0.b8() is e3q)
		{
			a1q = a1q.a(a1q, 2.0);
		}
		return a1q;
	}

	// Token: 0x0600B531 RID: 46385 RVA: 0x0040947C File Offset: 0x0040767C
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B532 RID: 46386 RVA: 0x00409484 File Offset: 0x00407684
	protected override float f0(cnm A_0)
	{
		return (float)bdk.f;
	}

	// Token: 0x0600B533 RID: 46387 RVA: 0x0040948C File Offset: 0x0040768C
	protected override int hi(cnm A_0)
	{
		return 20;
	}

	// Token: 0x040041FF RID: 16895
	private new const string a = "SA.AcidSpay";

	// Token: 0x04004200 RID: 16896
	private static readonly int b = d0u.b * 2;

	// Token: 0x04004201 RID: 16897
	private const int c = 5;

	// Token: 0x04004202 RID: 16898
	private const int d = 15;

	// Token: 0x04004203 RID: 16899
	public new static readonly int e = 6;

	// Token: 0x04004204 RID: 16900
	public static readonly int f = 4;

	// Token: 0x04004205 RID: 16901
	private new List<string> g;
}
