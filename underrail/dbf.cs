using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013B8 RID: 5048
[eiz("AYX1")]
[bs6("HFX:ignite")]
[Serializable]
public sealed class dbf : cpl, ISerializable
{
	// Token: 0x060071C7 RID: 29127 RVA: 0x002FC63C File Offset: 0x002FA83C
	private dbf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071C8 RID: 29128 RVA: 0x002FC648 File Offset: 0x002FA848
	public dbf()
	{
	}

	// Token: 0x060071C9 RID: 29129 RVA: 0x002FC654 File Offset: 0x002FA854
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
		awq.a(base.b(), true);
		if (base.agy().a != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(dbf.a.a.a)), new Func<csk, int>(dbf.a.a.b));
			if (num > 0 && !base.b().aa().Passive)
			{
				if (base.b().aa().d(CharacterImmunities.Burning))
				{
					etm a_ = new etm(new ap9(base.b().aa()), "burning");
					bey.a(a_, base.agw(), base.b());
					a7v.a(a_);
					bmj.a(base.b().a8(), new ba0());
				}
				else
				{
					int num2 = dht.b(base.agu());
					double num3 = dht.a(base.agu());
					int a_2 = (int)Math.Max(1.0, (double)num * num3 / (double)(num2 / d0u.b));
					bk9 bk = Enumerable.FirstOrDefault<bk9>(base.b().aa().StatusEffects.Get<bk9>());
					if (bk != null)
					{
						dd5.a(bk, (base.a() != null) ? base.a().aa() : null, a_2, num2);
					}
					else
					{
						base.b().aa().StatusEffects.a(new bk9(base.a().aa(), num2, a_2, false), false, false, false);
						dd5.a(base.b().aa());
					}
					vr a_3 = new vr(new ap9(base.b().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "{0} горит.", new Color?(adi.j), null);
					bey.a(a_3, base.agw(), base.b());
					a7v.a(a_3);
					if (base.a().a8().IsPlayer && !base.b().a8().IsPlayer)
					{
						cxc.a(eyy.b1);
					}
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x020013B9 RID: 5049
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060071CC RID: 29132 RVA: 0x002FC918 File Offset: 0x002FAB18
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Heat;
		}

		// Token: 0x060071CD RID: 29133 RVA: 0x002FC924 File Offset: 0x002FAB24
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E70 RID: 11888
		public static readonly dbf.a a = new dbf.a();

		// Token: 0x04002E71 RID: 11889
		public static Func<csk, bool> b;

		// Token: 0x04002E72 RID: 11890
		public static Func<csk, int> c;
	}
}
