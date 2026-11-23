using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013BA RID: 5050
[eiz("AEX9")]
[bs6("HFX:freeze")]
[Serializable]
public sealed class ra : cpl, ISerializable
{
	// Token: 0x060071CE RID: 29134 RVA: 0x002FC930 File Offset: 0x002FAB30
	private ra(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071CF RID: 29135 RVA: 0x002FC93C File Offset: 0x002FAB3C
	public ra()
	{
	}

	// Token: 0x060071D0 RID: 29136 RVA: 0x002FC948 File Offset: 0x002FAB48
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (!base.agw().b)
		{
			return dc4.c;
		}
		awq.e(base.b());
		if (base.agy().a != null)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(ra.a.a.a)), new Func<csk, int>(ra.a.a.b)) > 0)
			{
				awq.e(base.b());
				if (!base.b().aa().Passive)
				{
					if (base.b().aa().d(CharacterImmunities.Freeze) || base.b().aa().Defense.af()[DamageType.Cold].c() >= 1.0)
					{
						etm a_ = new etm(new ap9(base.b().aa()), "замерзанию");
						bey.a(a_, base.agw(), base.b());
						a7v.a(a_);
						bmj.a(base.b().a8(), new ba0());
					}
					else
					{
						if (base.b().a8() != null)
						{
							d4l.a(base.b().a8());
						}
						base.b().u();
						base.b().aa().StatusEffects.a(new a2(d0u.b * base.agu().Power, null), false, false, false);
						awq.b(base.b());
						if (base.b().a8() != null && base.b().a8().t.b != null)
						{
							base.b().a8().t.b.ah();
						}
						vr a_2 = new vr(new ap9(base.b().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "{0}: заморозка.", new Color?(adi.j), null);
						bey.a(a_2, base.agw(), base.b());
						a7v.a(a_2);
						if (base.a().a8().IsPlayer && !base.b().a8().IsPlayer)
						{
							cxc.a(eyy.bx);
						}
					}
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x020013BB RID: 5051
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060071D3 RID: 29139 RVA: 0x002FCC38 File Offset: 0x002FAE38
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Cold;
		}

		// Token: 0x060071D4 RID: 29140 RVA: 0x002FCC44 File Offset: 0x002FAE44
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E73 RID: 11891
		public static readonly ra.a a = new ra.a();

		// Token: 0x04002E74 RID: 11892
		public static Func<csk, bool> b;

		// Token: 0x04002E75 RID: 11893
		public static Func<csk, int> c;
	}
}
