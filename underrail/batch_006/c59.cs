using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001CC6 RID: 7366
[d29("PerfectScattering", "Perfect Scattering")]
public sealed class c59 : ai8
{
	// Token: 0x0600A199 RID: 41369 RVA: 0x003E7A7C File Offset: 0x003E5C7C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A19A RID: 41370 RVA: 0x003E7A84 File Offset: 0x003E5C84
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A19B RID: 41371 RVA: 0x003E7A88 File Offset: 0x003E5C88
	public c59() : base("膓Превосходный разброс")
	{
	}

	// Token: 0x0600A19C RID: 41372 RVA: 0x003E7A98 File Offset: 0x003E5C98
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A19D RID: 41373 RVA: 0x003E7A9C File Offset: 0x003E5C9C
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A19E RID: 41374 RVA: 0x003E7AA0 File Offset: 0x003E5CA0
	public override object[] at()
	{
		return new object[]
		{
			c59.a.LowerBoundary,
			c59.a.UpperBoundary
		};
	}

	// Token: 0x0600A19F RID: 41375 RVA: 0x003E7AE0 File Offset: 0x003E5CE0
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(65, new Type[]
			{
				typeof(ct7)
			})
		};
	}

	// Token: 0x04003E15 RID: 15893
	public new static readonly a1q a = new a1q(DamageType.Mechanical, 1, 2);
}
