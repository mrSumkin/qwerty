using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001377 RID: 4983
[eiz("IHEA")]
[bs6("HFX:immobilize")]
[Serializable]
public sealed class a3c : cpl, ISerializable
{
	// Token: 0x060070E8 RID: 28904 RVA: 0x002F6918 File Offset: 0x002F4B18
	private a3c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070E9 RID: 28905 RVA: 0x002F6924 File Offset: 0x002F4B24
	public a3c()
	{
	}

	// Token: 0x060070EA RID: 28906 RVA: 0x002F6930 File Offset: 0x002F4B30
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (base.agw().b && base.agy().a != null)
		{
			if (Enumerable.Sum<csk>(base.agy().a, new Func<csk, int>(a3c.a.a.a)) != 0 && !base.agw().c.GetValueOrDefault())
			{
				if (base.b().aa().d(CharacterImmunities.Root))
				{
					etm a_ = new etm(new ap9(base.b().aa()), "обездвиживанию");
					bey.a(a_, base.agw(), base.b());
					a7v.a(a_);
					bmj.a(base.b().a8(), new ba0());
				}
				else if (euf.k(base.b().aa()))
				{
					bjq a_2 = new bjq(new ap9(base.b().aa()), null, "обездвиживанию");
					bey.a(a_2, base.agw(), base.b());
					a7v.a(a_2);
					bmj.a(base.b().a8(), new bgj());
				}
				else
				{
					base.b().aa().StatusEffects.a(new bo4(base.agu().Power * d0u.b), false, false, false);
					vr a_3 = new vr(new ap9(base.b().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "{0}: обездвижен.", new Color?(adi.j), null);
					bey.a(a_3, base.agw(), base.b());
					a7v.a(a_3);
				}
				return dc4.c;
			}
		}
		return dc4.c;
	}

	// Token: 0x02001378 RID: 4984
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060070ED RID: 28909 RVA: 0x002F6B5C File Offset: 0x002F4D5C
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E2B RID: 11819
		public static readonly a3c.a a = new a3c.a();

		// Token: 0x04002E2C RID: 11820
		public static Func<csk, int> b;
	}
}
