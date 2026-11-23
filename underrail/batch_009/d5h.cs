using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x0200038D RID: 909
[fe("mistPsiBeetle")]
public sealed class d5h : ed4
{
	// Token: 0x06001930 RID: 6448 RVA: 0x000841E4 File Offset: 0x000823E4
	public d5h(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new byh("EnterStealth", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(d5h.a.a.a), null)
		{
			e = false
		});
		base.a(list);
	}

	// Token: 0x06001931 RID: 6449 RVA: 0x00084258 File Offset: 0x00082458
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (!amc.aa().SpecialStates.g && !amc.aa().IsInCombat && amc.aa().SpecialAbilities.a(typeof(e5b)))
		{
			bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(amc)), null) as bl6;
			if (bl != null && bl.yw())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001932 RID: 6450 RVA: 0x000842E0 File Offset: 0x000824E0
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (!amc.aa().SpecialStates.g)
		{
			bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(amc)), null) as bl6;
			if (bl != null && bl.yw())
			{
				return cp.a(bl, amc.a8(), false);
			}
		}
		return null;
	}

	// Token: 0x0200038F RID: 911
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001938 RID: 6456 RVA: 0x000845F0 File Offset: 0x000827F0
		internal float a(bool A_0)
		{
			return 0.95f;
		}

		// Token: 0x04000E75 RID: 3701
		public static readonly d5h.a a = new d5h.a();

		// Token: 0x04000E76 RID: 3702
		public static Func<bool, float> b;
	}
}
