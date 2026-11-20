using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013A5 RID: 5029
[eiz("SI7X")]
[bs6("HFX:sporeInfection")]
[Serializable]
public sealed class b3y : cpl, ISerializable
{
	// Token: 0x06007186 RID: 29062 RVA: 0x002FA6EC File Offset: 0x002F88EC
	private b3y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007187 RID: 29063 RVA: 0x002FA6F8 File Offset: 0x002F88F8
	public b3y()
	{
	}

	// Token: 0x06007188 RID: 29064 RVA: 0x002FA704 File Offset: 0x002F8904
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
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(b3y.a.a.a)), new Func<csk, int>(b3y.a.a.b)) > 0)
			{
				if (!base.b().aa().Passive && !base.b().aa().b(d8o.e) && base.b().aa().Defense.af()[DamageType.Bio].c() < 1.0)
				{
					base.b().aa().StatusEffects.a(new c1c(d0u.b * 10), false, false, false);
				}
				else
				{
					etm a_ = new etm(new ap9(base.b().aa()), "spores");
					bey.a(a_, base.agw(), base.b());
					a7v.a(a_);
					bmj.a(base.b().a8(), new ba0());
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x020013A6 RID: 5030
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600718B RID: 29067 RVA: 0x002FA8D4 File Offset: 0x002F8AD4
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Bio;
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x002FA8E0 File Offset: 0x002F8AE0
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E5E RID: 11870
		public static readonly b3y.a a = new b3y.a();

		// Token: 0x04002E5F RID: 11871
		public static Func<csk, bool> b;

		// Token: 0x04002E60 RID: 11872
		public static Func<csk, int> c;
	}
}
