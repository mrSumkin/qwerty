using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02002183 RID: 8579
[dp2("1.0.3.2_RootToSlowImmunityTabiChange", "1.0.3.2")]
public sealed class e8e : dnv
{
	// Token: 0x0600C955 RID: 51541 RVA: 0x004724FC File Offset: 0x004706FC
	public bool eq(bk3 A_0)
	{
		c5s c5s = A_0 as c5s;
		if (c5s != null)
		{
			int num = c5s.ar().FindIndex(new Predicate<d3e>(e8e.a.a.a));
			if (num != -1)
			{
				c5s.ar()[num] = new awe(CharacterImmunities.Slow);
			}
		}
		return true;
	}

	// Token: 0x0600C956 RID: 51542 RVA: 0x00472564 File Offset: 0x00470764
	public bool er(coh A_0)
	{
		return true;
	}

	// Token: 0x02002184 RID: 8580
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600C95A RID: 51546 RVA: 0x00472584 File Offset: 0x00470784
		internal bool a(d3e A_0)
		{
			return A_0 is awe && ((awe)A_0).Immunity == CharacterImmunities.Root;
		}

		// Token: 0x04004A09 RID: 18953
		public static readonly e8e.a a = new e8e.a();

		// Token: 0x04004A0A RID: 18954
		public static Predicate<d3e> b;
	}
}
