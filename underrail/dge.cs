using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020013CE RID: 5070
[eiz("SHEA")]
[bs6("HFX:ST")]
[Serializable]
public sealed class dge : cpl, ISerializable
{
	// Token: 0x0600721C RID: 29212 RVA: 0x002FF704 File Offset: 0x002FD904
	private dge(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600721D RID: 29213 RVA: 0x002FF710 File Offset: 0x002FD910
	public dge()
	{
	}

	// Token: 0x0600721E RID: 29214 RVA: 0x002FF71C File Offset: 0x002FD91C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (base.agw().b && !base.agw().c.GetValueOrDefault() && base.agy().a != null)
		{
			if (Enumerable.Sum<csk>(base.agy().a, new Func<csk, int>(dge.a.a.a)) != 0)
			{
				if (base.b().aa().c(d8o.e) || base.b().aa().d(CharacterImmunities.Stun))
				{
					etm a_ = new etm(new ap9(base.b().aa()), "эффекту оглушения");
					bey.a(a_, base.agw(), base.b());
					a7v.a(a_);
					bmj.a(base.b().a8(), new ba0());
				}
				else if (euf.l(base.b().aa()))
				{
					c6f a_2 = new c6f(new ap9(base.b().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "оглушению");
					bey.a(a_2, base.agw(), base.b());
					a7v.a(a_2);
					bmj.a(base.b().a8(), new dym());
				}
				else
				{
					string str;
					els els = awq.a(base.b().aa(), base.agu().Power * d0u.b, out str);
					base.b().aa().StatusEffects.a(els, false, false, false);
					vr a_3 = new vr(new ap9(base.b().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "{0}: " + str + ".", new Color?(adi.j), null);
					base.b().a8().c().a(Guid.NewGuid().ToString(), "Stun", 1f, c9z.a, false, false);
					bey.a(a_3, base.agw(), base.b());
					a7v.a(a_3);
					if (base.a().aa() is e3q && !(base.b().aa() is e3q) && els is ab3)
					{
						cxc.a(eyy.by);
					}
				}
				return dc4.c;
			}
		}
		return dc4.c;
	}

	// Token: 0x020013CF RID: 5071
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007221 RID: 29217 RVA: 0x002FFA0C File Offset: 0x002FDC0C
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E8F RID: 11919
		public static readonly dge.a a = new dge.a();

		// Token: 0x04002E90 RID: 11920
		public static Func<csk, int> b;
	}
}
