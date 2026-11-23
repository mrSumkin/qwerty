using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020012C0 RID: 4800
[eiz("SGEA5")]
[Serializable]
public sealed class d5p : cry, ISerializable, chb, c98
{
	// Token: 0x060069D5 RID: 27093 RVA: 0x002C9C2C File Offset: 0x002C7E2C
	private d5p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060069D6 RID: 27094 RVA: 0x002C9C38 File Offset: 0x002C7E38
	public override string gv()
	{
		return "спорам";
	}

	// Token: 0x060069D7 RID: 27095 RVA: 0x002C9C40 File Offset: 0x002C7E40
	public override bool gw()
	{
		return false;
	}

	// Token: 0x060069D8 RID: 27096 RVA: 0x002C9C44 File Offset: 0x002C7E44
	public d5p(c5x A_0, string A_1, Guid? A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x060069D9 RID: 27097 RVA: 0x002C9C54 File Offset: 0x002C7E54
	public override void gx(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().b(d8o.e) && A_0.h.b.aa().Defense.af()[DamageType.Bio].c() < 1.0)
		{
			A_0.h.b.aa().StatusEffects.a(new c1c(d0u.b * 10), false, false, false);
		}
	}

	// Token: 0x060069DA RID: 27098 RVA: 0x002C9D10 File Offset: 0x002C7F10
	protected override void gy(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().b(d8o.e) && A_0.h.b.aa().Defense.af()[DamageType.Bio].c() < 1.0)
		{
			A_0.h.b.aa().StatusEffects.a(new c1c(d0u.b * 10), false, false, false);
		}
	}
}
