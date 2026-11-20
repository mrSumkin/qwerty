using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200125D RID: 4701
[eiz("Z61")]
[Serializable]
public sealed class dn : arn, ISerializable
{
	// Token: 0x060065B1 RID: 26033 RVA: 0x002B4A98 File Offset: 0x002B2C98
	private dn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060065B2 RID: 26034 RVA: 0x002B4AA4 File Offset: 0x002B2CA4
	public dn(c5x A_0, EntityAspectReference<amc, amc> A_1, int A_2, coh A_3) : base(A_0, A_1, A_2, A_3)
	{
	}

	// Token: 0x060065B3 RID: 26035 RVA: 0x002B4AB4 File Offset: 0x002B2CB4
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
			int o = ezx.o;
			int num2 = ezx.l;
			if (base.b() != null && base.b().aa().Feats.Contains<dt>())
			{
				num2 = (int)((double)num2 * (1.0 + dt.a(base.b().aa())));
			}
			int num3 = (int)Math.Max(1.0, (double)o * (1.0 - num));
			vs a_2 = new vs((base.b() != null) ? base.b().aa() : null, num3 * d0u.b, num2);
			A_0.h.b.aa().StatusEffects.a(a_2, false, false, false);
		}
	}
}
