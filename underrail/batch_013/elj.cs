using System;
using System.Collections.Generic;

// Token: 0x02001CD9 RID: 7385
[d29("ShootingSpree", "Shooting Spree")]
public sealed class elj : ai8
{
	// Token: 0x0600A219 RID: 41497 RVA: 0x003E884C File Offset: 0x003E6A4C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A21A RID: 41498 RVA: 0x003E8854 File Offset: 0x003E6A54
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A21B RID: 41499 RVA: 0x003E8858 File Offset: 0x003E6A58
	public elj() : base("膁Весёлая стрельба")
	{
	}

	// Token: 0x0600A21C RID: 41500 RVA: 0x003E8868 File Offset: 0x003E6A68
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<bcq>());
	}

	// Token: 0x0600A21D RID: 41501 RVA: 0x003E887C File Offset: 0x003E6A7C
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<bcq>());
	}

	// Token: 0x0600A21E RID: 41502 RVA: 0x003E8890 File Offset: 0x003E6A90
	public override object[] at()
	{
		return new object[]
		{
			l4.a(elj.a, false),
			l4.a(elj.b, false)
		};
	}

	// Token: 0x0600A21F RID: 41503 RVA: 0x003E88B4 File Offset: 0x003E6AB4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(55, new Type[]
			{
				typeof(ct7)
			}),
			new b4k(new Type[]
			{
				typeof(avk)
			})
		};
	}

	// Token: 0x04003E25 RID: 15909
	public new static readonly int a = 1;

	// Token: 0x04003E26 RID: 15910
	public new static readonly int b = 10;
}
