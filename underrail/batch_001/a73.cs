using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001370 RID: 4976
[bs6("HFX:dazeNearbyOnAttack")]
[eiz("DZHENA")]
[Serializable]
public sealed class a73 : cpl, ISerializable
{
	// Token: 0x060070CC RID: 28876 RVA: 0x002F5B68 File Offset: 0x002F3D68
	private a73(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070CD RID: 28877 RVA: 0x002F5B74 File Offset: 0x002F3D74
	public a73()
	{
	}

	// Token: 0x060070CE RID: 28878 RVA: 0x002F5B80 File Offset: 0x002F3D80
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.agu() == null || base.a() == null || base.a().a8() == null || base.a().a8().Area == null)
		{
			return dc4.e;
		}
		if (base.agw().b && base.agy().a != null)
		{
			if (Enumerable.Sum<csk>(base.agy().a, new Func<csk, int>(a73.a.a.a)) != 0 && !base.agw().c.GetValueOrDefault())
			{
				List<amc> list = aw1.a(base.a().a8(), 1);
				bool flag = false;
				if (list != null && list.Count > 0)
				{
					foreach (amc amc in list)
					{
						if (!amc.aa().Passive && !amc.aa().c(d8o.e) && !amc.aa().d(CharacterImmunities.Daze))
						{
							if (euf.l(amc.aa()))
							{
								c6f a_ = new c6f(new ap9(amc.aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "дезориентации");
								bey.a(a_, base.agw(), amc);
								a7v.a(a_);
								bmj.a(amc.a8(), new dym());
							}
							else
							{
								amc.aa().StatusEffects.a(new eok(base.agu().Power * d0u.b), false, false, false);
								vr a_2 = new vr(new ap9(amc.aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "{0}: дезориентация.", new Color?(adi.j), null);
								if (!flag)
								{
									flag = true;
									amc.a8().c().a(Guid.NewGuid().ToString(), "Stun", 1f, c9z.a, false, false);
								}
								bey.a(a_2, base.agw(), amc);
								a7v.a(a_2);
							}
						}
					}
				}
				return dc4.c;
			}
		}
		return dc4.c;
	}

	// Token: 0x02001371 RID: 4977
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060070D1 RID: 28881 RVA: 0x002F5E20 File Offset: 0x002F4020
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E22 RID: 11810
		public static readonly a73.a a = new a73.a();

		// Token: 0x04002E23 RID: 11811
		public static Func<csk, int> b;
	}
}
