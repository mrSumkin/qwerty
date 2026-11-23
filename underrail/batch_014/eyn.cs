using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200060A RID: 1546
[e7l(SpellTargetType.CreatureWithLastDamage)]
public sealed class eyn : emk
{
	// Token: 0x06002834 RID: 10292 RVA: 0x000E7DF8 File Offset: 0x000E5FF8
	public eyn(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002835 RID: 10293 RVA: 0x000E7E04 File Offset: 0x000E6004
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		if (c5x == null || c5x.h.b == null)
		{
			return false;
		}
		List<csk> classPropertyValue = c5x.h.b.aa().CustomProperties.GetClassPropertyValue<List<csk>>(ddm.g);
		if (classPropertyValue != null)
		{
			return Enumerable.Sum<csk>(classPropertyValue, new Func<csk, int>(eyn.a.a.a)) > 0;
		}
		return false;
	}

	// Token: 0x0200060B RID: 1547
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002838 RID: 10296 RVA: 0x000E7E98 File Offset: 0x000E6098
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04001650 RID: 5712
		public static readonly eyn.a a = new eyn.a();

		// Token: 0x04001651 RID: 5713
		public static Func<csk, int> b;
	}
}
