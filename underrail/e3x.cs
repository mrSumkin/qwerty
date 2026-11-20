using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020012C7 RID: 4807
[eiz("C62")]
[Serializable]
public sealed class e3x : arn, ISerializable
{
	// Token: 0x06006A1E RID: 27166 RVA: 0x002CBE20 File Offset: 0x002CA020
	private e3x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006A1F RID: 27167 RVA: 0x002CBE2C File Offset: 0x002CA02C
	public e3x(c5x A_0, EntityAspectReference<amc, amc> A_1, int A_2, coh A_3) : base(A_0, A_1, A_2, A_3)
	{
	}

	// Token: 0x06006A20 RID: 27168 RVA: 0x002CBE3C File Offset: 0x002CA03C
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
			int num2 = cl5.d(base.a());
			bhe a_2 = new bhe((int)Math.Max(1.0, (double)num2 * (1.0 - num)) * d0u.b);
			A_0.h.b.aa().StatusEffects.a(a_2, false, false, false);
		}
	}
}
