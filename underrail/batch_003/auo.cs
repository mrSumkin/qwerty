using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200137D RID: 4989
[bs6("HFX:carveUp")]
[eiz("CUHEA")]
[Serializable]
public sealed class auo : cpl, ISerializable
{
	// Token: 0x060070FE RID: 28926 RVA: 0x002F73F0 File Offset: 0x002F55F0
	private auo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070FF RID: 28927 RVA: 0x002F73FC File Offset: 0x002F55FC
	public auo()
	{
	}

	// Token: 0x06007100 RID: 28928 RVA: 0x002F7404 File Offset: 0x002F5604
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (!base.agw().b || base.agw().c.GetValueOrDefault())
		{
			return dc4.c;
		}
		if (base.agy().a != null)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(auo.a.a.a)), new Func<csk, int>(auo.a.a.b)) > 0 && !base.b().aa().Passive && !base.b().aa().b(d8o.e))
			{
				base.b().aa().StatusEffects.a(new a36(), false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x0200137E RID: 4990
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007103 RID: 28931 RVA: 0x002F7550 File Offset: 0x002F5750
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x002F755C File Offset: 0x002F575C
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E33 RID: 11827
		public static readonly auo.a a = new auo.a();

		// Token: 0x04002E34 RID: 11828
		public static Func<csk, bool> b;

		// Token: 0x04002E35 RID: 11829
		public static Func<csk, int> c;
	}
}
