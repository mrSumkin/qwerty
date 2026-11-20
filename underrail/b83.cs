using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200139D RID: 5021
[bs6("HFX:psiInhib")]
[eiz("PSIHY")]
[Serializable]
public sealed class b83 : cpl, ISerializable
{
	// Token: 0x0600716D RID: 29037 RVA: 0x002F9CA0 File Offset: 0x002F7EA0
	private b83(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600716E RID: 29038 RVA: 0x002F9CAC File Offset: 0x002F7EAC
	public b83()
	{
	}

	// Token: 0x0600716F RID: 29039 RVA: 0x002F9CB4 File Offset: 0x002F7EB4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (base.agw().b && !base.agw().c.GetValueOrDefault() && base.agy().a != null)
		{
			if (Enumerable.Sum<csk>(base.agy().a, new Func<csk, int>(b83.a.a.a)) != 0)
			{
				c5x c5x = base.b().a8();
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				if (!c5x.h.b.aa().Passive && !c5x.h.b.aa().c(d8o.e))
				{
					if (c5x.h.b.aa().d(CharacterImmunities.MindAffecting) || !c5x.h.b.aa().Feats.Contains<c3v>())
					{
						etm a_ = new etm(new ap9(c5x.h.b.aa()), "пси угнетению");
						bey.a(a_, base.a().aa(), c5x.h.b.aa(), c5x.h.b);
						a7v.a(a_);
						bmj.a(c5x, new ba0());
					}
					else if (euf.f(euf.n(c5x.h.b.aa()), c5x.h.b.aa()))
					{
						c6f a_2 = new c6f(new ap9(c5x.h.b.aa()), new ap9(base.a().aa()), "псионическому угнетению");
						bey.a(a_2, base.a().aa(), c5x.h.b.aa(), c5x.h.b);
						qy.ad().Add(new b8p(c5x, new dym()));
						qy.ad().Add(new anw(a_2));
					}
					else
					{
						adg adg = new adg(base.agu().Power * d0u.b);
						qy.ad().Add(new amd(c5x.h.b, new els[]
						{
							adg
						}));
					}
				}
				c5x.Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
				return dc4.c;
			}
		}
		return dc4.c;
	}

	// Token: 0x0200139E RID: 5022
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007172 RID: 29042 RVA: 0x002F9F8C File Offset: 0x002F818C
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E55 RID: 11861
		public static readonly b83.a a = new b83.a();

		// Token: 0x04002E56 RID: 11862
		public static Func<csk, int> b;
	}
}
