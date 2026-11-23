using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200060C RID: 1548
[e7l(SpellTargetType.CreatureNotSelfWithLastDamage)]
public sealed class cgt : emk
{
	// Token: 0x06002839 RID: 10297 RVA: 0x000E7EA4 File Offset: 0x000E60A4
	public cgt(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600283A RID: 10298 RVA: 0x000E7EB0 File Offset: 0x000E60B0
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.@as())
		{
			return false;
		}
		List<csk> classPropertyValue = c5x.h.b.aa().CustomProperties.GetClassPropertyValue<List<csk>>(ddm.g);
		if (classPropertyValue != null)
		{
			return Enumerable.Sum<csk>(classPropertyValue, new Func<csk, int>(cgt.a.a.a)) > 0;
		}
		return false;
	}

	// Token: 0x0200060D RID: 1549
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600283D RID: 10301 RVA: 0x000E7F58 File Offset: 0x000E6158
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04001652 RID: 5714
		public static readonly cgt.a a = new cgt.a();

		// Token: 0x04001653 RID: 5715
		public static Func<csk, int> b;
	}
}
