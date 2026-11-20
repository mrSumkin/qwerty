using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013AB RID: 5035
[eiz("AEX1")]
[bs6("HFX:acidicEntanglement")]
[Serializable]
public sealed class bk1 : cpl, ISerializable
{
	// Token: 0x0600719A RID: 29082 RVA: 0x002FB148 File Offset: 0x002F9348
	private bk1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600719B RID: 29083 RVA: 0x002FB154 File Offset: 0x002F9354
	public bk1()
	{
	}

	// Token: 0x0600719C RID: 29084 RVA: 0x002FB160 File Offset: 0x002F9360
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
		if (!base.b().aa().Passive)
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
				bjq a_2 = new bjq(new ap9(base.b().aa()), null, "кислотного опутывания");
				bey.a(a_2, base.agw(), base.b());
				a7v.a(a_2);
				bmj.a(base.b().a8(), new bgj());
			}
			else
			{
				int num = ate.b(base.agu());
				int num2 = Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agw().f, new Func<csk, bool>(bk1.a.a.a)), new Func<csk, int>(bk1.a.a.b));
				double num3 = ate.a(base.agu());
				int a_3 = (int)Math.Max(1.0, (double)num2 * num3 / (double)(num / d0u.b));
				if (base.agw() != null && base.agw().x == AmmoType.Vial_Acid_Corrosive)
				{
					base.b().aa().StatusEffects.a(new br1(base.a().aa(), num, a_3), false, false, false);
				}
				else if (base.agw() != null && base.agw().x == AmmoType.Vial_Acid_Rusting)
				{
					base.b().aa().StatusEffects.a(new bgv(base.a().aa(), num, a_3), false, false, false);
				}
				else
				{
					base.b().aa().StatusEffects.a(new e32(base.a().aa(), num, a_3), false, false, false);
				}
				vr a_4 = new vr(new ap9(base.b().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "{0}: опутывание.", new Color?(adi.j), null);
				bey.a(a_4, base.agw(), base.b());
				a7v.a(a_4);
			}
		}
		return dc4.c;
	}

	// Token: 0x020013AC RID: 5036
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600719F RID: 29087 RVA: 0x002FB484 File Offset: 0x002F9684
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Acid;
		}

		// Token: 0x060071A0 RID: 29088 RVA: 0x002FB490 File Offset: 0x002F9690
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E64 RID: 11876
		public static readonly bk1.a a = new bk1.a();

		// Token: 0x04002E65 RID: 11877
		public static Func<csk, bool> b;

		// Token: 0x04002E66 RID: 11878
		public static Func<csk, int> c;
	}
}
