using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001367 RID: 4967
[bs6("HFX:contaminateDot")]
[eiz("CDTA")]
[Serializable]
public sealed class ews : cpl, ISerializable
{
	// Token: 0x060070AD RID: 28845 RVA: 0x002F4EE0 File Offset: 0x002F30E0
	private ews(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070AE RID: 28846 RVA: 0x002F4EEC File Offset: 0x002F30EC
	public ews()
	{
	}

	// Token: 0x060070AF RID: 28847 RVA: 0x002F4EF8 File Offset: 0x002F30F8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (!base.agw().b || base.agw().c.GetValueOrDefault() || base.b().aa().b(d8o.e))
		{
			return dc4.c;
		}
		if (!base.b().aa().Passive && !base.b().aa().b(d8o.e))
		{
			int num;
			if (base.agy() == null || base.agy().a == null)
			{
				num = 0;
			}
			else
			{
				num = Enumerable.Sum<csk>(base.agy().a, new Func<csk, int>(ews.a.a.a));
			}
			if (num > 0)
			{
				if (base.b().aa().d(CharacterImmunities.Biohazard))
				{
					etm a_ = new etm(new ap9(base.b().aa()), "загрязнению");
					bey.a(a_, base.agw(), base.b());
					a7v.a(a_);
					bmj.a(base.b().a8(), new ba0());
				}
				else
				{
					a1q a_2 = dmj.a(base.agu());
					int a_3 = Math.Max(1, euf.a(a_2, 1.0).Amount / dmj.a);
					fp a_4 = new fp((base.a() != null) ? base.a().aa().FactionId : null, dmj.a * d0u.b, a_3, base.c());
					base.b().aa().StatusEffects.a(a_4, false, false, false);
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x02001368 RID: 4968
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060070B2 RID: 28850 RVA: 0x002F5110 File Offset: 0x002F3310
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E19 RID: 11801
		public static readonly ews.a a = new ews.a();

		// Token: 0x04002E1A RID: 11802
		public static Func<csk, int> b;
	}
}
