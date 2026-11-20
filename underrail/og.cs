using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020013A1 RID: 5025
[bs6("HFX:fear")]
[eiz("FRY")]
[Serializable]
public sealed class og : cpl, ISerializable
{
	// Token: 0x06007179 RID: 29049 RVA: 0x002FA268 File Offset: 0x002F8468
	private og(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600717A RID: 29050 RVA: 0x002FA274 File Offset: 0x002F8474
	public og()
	{
	}

	// Token: 0x0600717B RID: 29051 RVA: 0x002FA27C File Offset: 0x002F847C
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
			if (Enumerable.Sum<csk>(base.agy().a, new Func<csk, int>(og.a.a.a)) > 0 && !base.b().aa().Passive && !base.b().aa().b(d8o.e))
			{
				if (base.b().aa().d(CharacterImmunities.Fear))
				{
					etm a_ = new etm(new ap9(base.b().aa()), "страху");
					bey.a(a_, base.agw(), base.b());
					a7v.a(a_);
					bmj.a(base.b().a8(), new ba0());
				}
				else
				{
					int a_2 = euf.n(base.b().aa());
					if (euf.f(a_2, base.b().aa()))
					{
						c6f a_3 = new c6f(new ap9(base.b().aa()), new ap9(base.a().aa()), "страху");
						bey.a(a_3, base.a().aa(), base.b().aa(), base.b());
						a7v.a(a_3);
						bmj.a(base.b().a8(), new dym());
					}
					else
					{
						double num = euf.d(a_2, base.b().aa());
						int a_4 = (int)d05.b((double)d0u.b, Math.Ceiling((1.0 - num) * (double)base.agu().Power * (double)d0u.b / (double)d0u.b) * (double)d0u.b, (double)(base.agu().Power * d0u.b));
						base.b().aa().StatusEffects.a(new axo(a_4, base.a()), false, false, false);
						vr a_5 = new vr(new ap9(base.b().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "{0} паникует.", new Color?(adi.j), null);
						bey.a(a_5, base.agw(), base.b());
						a7v.a(a_5);
					}
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x020013A2 RID: 5026
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600717E RID: 29054 RVA: 0x002FA560 File Offset: 0x002F8760
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E59 RID: 11865
		public static readonly og.a a = new og.a();

		// Token: 0x04002E5A RID: 11866
		public static Func<csk, int> b;
	}
}
