using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200139F RID: 5023
[bs6("HFX:daze")]
[eiz("DZHEA")]
[Serializable]
public sealed class aic : cpl, ISerializable
{
	// Token: 0x06007173 RID: 29043 RVA: 0x002F9F98 File Offset: 0x002F8198
	private aic(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007174 RID: 29044 RVA: 0x002F9FA4 File Offset: 0x002F81A4
	public aic()
	{
	}

	// Token: 0x06007175 RID: 29045 RVA: 0x002F9FAC File Offset: 0x002F81AC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (base.agw().b && base.agy().a != null)
		{
			if (Enumerable.Sum<csk>(base.agy().a, new Func<csk, int>(aic.a.a.a)) != 0 && !base.agw().c.GetValueOrDefault())
			{
				if (base.b().aa().Passive || base.b().aa().c(d8o.e) || base.b().aa().d(CharacterImmunities.Daze))
				{
					etm a_ = new etm(new ap9(base.b().aa()), "дезориентации");
					bey.a(a_, base.agw(), base.b());
					a7v.a(a_);
					bmj.a(base.b().a8(), new ba0());
				}
				else if (euf.l(base.b().aa()))
				{
					c6f a_2 = new c6f(new ap9(base.b().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "дезориентации");
					bey.a(a_2, base.agw(), base.b());
					a7v.a(a_2);
					bmj.a(base.b().a8(), new dym());
				}
				else
				{
					base.b().aa().StatusEffects.a(new eok(base.agu().Power * d0u.b), false, false, false);
					vr a_3 = new vr(new ap9(base.b().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "{0}: дезориентация.", new Color?(adi.j), null);
					base.b().a8().c().a(Guid.NewGuid().ToString(), "Stun", 1f, c9z.a, false, false);
					bey.a(a_3, base.agw(), base.b());
					a7v.a(a_3);
				}
				return dc4.c;
			}
		}
		return dc4.c;
	}

	// Token: 0x020013A0 RID: 5024
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007178 RID: 29048 RVA: 0x002FA25C File Offset: 0x002F845C
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E57 RID: 11863
		public static readonly aic.a a = new aic.a();

		// Token: 0x04002E58 RID: 11864
		public static Func<csk, int> b;
	}
}
