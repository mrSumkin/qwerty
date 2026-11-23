using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013A3 RID: 5027
[eiz("CRPY")]
[bs6("HFX:cripple")]
[Serializable]
public sealed class czt : cpl, ISerializable
{
	// Token: 0x0600717F RID: 29055 RVA: 0x002FA56C File Offset: 0x002F876C
	private czt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007180 RID: 29056 RVA: 0x002FA578 File Offset: 0x002F8778
	public czt()
	{
	}

	// Token: 0x06007181 RID: 29057 RVA: 0x002FA584 File Offset: 0x002F8784
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
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(czt.a.a.a)), new Func<csk, int>(czt.a.a.b)) > 0 && !base.b().aa().Passive && !base.b().aa().b(d8o.e))
			{
				base.b().aa().StatusEffects.a(new cgs(fz.c), false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x020013A4 RID: 5028
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007184 RID: 29060 RVA: 0x002FA6D4 File Offset: 0x002F88D4
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06007185 RID: 29061 RVA: 0x002FA6E0 File Offset: 0x002F88E0
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E5B RID: 11867
		public static readonly czt.a a = new czt.a();

		// Token: 0x04002E5C RID: 11868
		public static Func<csk, bool> b;

		// Token: 0x04002E5D RID: 11869
		public static Func<csk, int> c;
	}
}
