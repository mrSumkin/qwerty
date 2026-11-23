using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020012C6 RID: 4806
[eiz("C61")]
[Serializable]
public sealed class cdr : arn, ISerializable
{
	// Token: 0x06006A1B RID: 27163 RVA: 0x002CBC28 File Offset: 0x002C9E28
	private cdr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006A1C RID: 27164 RVA: 0x002CBC34 File Offset: 0x002C9E34
	public cdr(c5x A_0, EntityAspectReference<amc, amc> A_1, int A_2, coh A_3) : base(A_0, A_1, A_2, A_3)
	{
	}

	// Token: 0x06006A1D RID: 27165 RVA: 0x002CBC44 File Offset: 0x002C9E44
	protected override void ed(c5x A_0, int A_1)
	{
		base.ed(A_0, A_1);
		if (A_0 != null && A_0.h.b != null)
		{
			if (A_0.h.b.aa().Passive || A_0.h.b.aa().b(d8o.e) || A_0.h.b.aa().d(CharacterImmunities.Poison))
			{
				if (base.b() != null)
				{
					etm a_ = new etm(new ap9(A_0.h.b.aa()), "яду");
					bey.a(a_, base.b().aa(), A_0.h.b.aa(), A_0.h.b);
					a7v.a(a_);
				}
				bmj.a(A_0, new ba0());
				return;
			}
			double num = euf.d(A_0.h.b.aa(), 1.0);
			int a = czw.a;
			int c = czw.c;
			int num2 = czw.b;
			string a_2 = "BurrowerPoison";
			string a_3 = "Яд могильщика";
			if (base.b() != null && base.b().aa().Feats.Contains<dt>())
			{
				num2 = (int)((double)num2 * (1.0 + dt.a(base.b().aa())));
			}
			int num3 = (int)Math.Max(1.0, (double)a * (1.0 - num));
			c2b a_4 = new c2b((base.b() != null) ? base.b().aa() : null, a_2, a_3, num3 * d0u.b, num2, c);
			A_0.h.b.aa().StatusEffects.a(a_4, false, false, false);
		}
	}
}
