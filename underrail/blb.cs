using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F4E RID: 8014
[ayj("PlaceBearTrap")]
public class blb : dg1
{
	// Token: 0x0600BB21 RID: 47905 RVA: 0x00414344 File Offset: 0x00412544
	public override string y8()
	{
		return "Place Bear Trap";
	}

	// Token: 0x0600BB22 RID: 47906 RVA: 0x0041434C File Offset: 0x0041254C
	public override string os()
	{
		return "PlaceBearTrap";
	}

	// Token: 0x0600BB23 RID: 47907 RVA: 0x00414354 File Offset: 0x00412554
	public override string bp(cnm A_0)
	{
		c18.a(A_0);
		return qv.a("Traps/BearTrap", new object[]
		{
			blb.a().a(true),
			(int)(blb.c * 100.0),
			l4.a(blb.d, false),
			l4.a(blb.e, false)
		});
	}

	// Token: 0x0600BB24 RID: 47908 RVA: 0x004143C0 File Offset: 0x004125C0
	public new static a1q a()
	{
		return new a1q(DamageType.Mechanical, 35, 40);
	}

	// Token: 0x040043DD RID: 17373
	private new const int a = 35;

	// Token: 0x040043DE RID: 17374
	private const int b = 40;

	// Token: 0x040043DF RID: 17375
	public static readonly double c = 1.0;

	// Token: 0x040043E0 RID: 17376
	public static readonly int d = 3;

	// Token: 0x040043E1 RID: 17377
	public new static readonly int e = 3;
}
