using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013AD RID: 5037
[eiz("AEX3")]
[bs6("HFX:chill")]
[Serializable]
public sealed class abj : cpl, ISerializable
{
	// Token: 0x060071A1 RID: 29089 RVA: 0x002FB49C File Offset: 0x002F969C
	private abj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071A2 RID: 29090 RVA: 0x002FB4A8 File Offset: 0x002F96A8
	public abj()
	{
	}

	// Token: 0x060071A3 RID: 29091 RVA: 0x002FB4B4 File Offset: 0x002F96B4
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
		awq.e(base.b());
		if (base.agy().a != null)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(abj.a.a.a)), new Func<csk, int>(abj.a.a.b)) > 0 && !base.b().aa().Passive)
			{
				if (base.b().aa().d(CharacterImmunities.Chill) || base.b().aa().Defense.af()[DamageType.Cold].c() >= 1.0)
				{
					etm a_ = new etm(new ap9(base.b().aa()), "эффекту переохлаждения");
					bey.a(a_, base.agw(), base.b());
					a7v.a(a_);
					bmj.a(base.b().a8(), new ba0());
				}
				else
				{
					int a_2 = d4i.a(base.agu());
					base.b().aa().StatusEffects.a(new b34(a_2, h7.i), false, false, false);
					awq.c(base.b());
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x020013AE RID: 5038
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060071A6 RID: 29094 RVA: 0x002FB6A4 File Offset: 0x002F98A4
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Cold;
		}

		// Token: 0x060071A7 RID: 29095 RVA: 0x002FB6B0 File Offset: 0x002F98B0
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E67 RID: 11879
		public static readonly abj.a a = new abj.a();

		// Token: 0x04002E68 RID: 11880
		public static Func<csk, bool> b;

		// Token: 0x04002E69 RID: 11881
		public static Func<csk, int> c;
	}
}
