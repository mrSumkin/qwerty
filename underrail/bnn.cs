using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020011F6 RID: 4598
[eiz("HBPBTT")]
[Serializable]
public sealed class bnn : azv, ISerializable
{
	// Token: 0x060062C3 RID: 25283 RVA: 0x002AB2A8 File Offset: 0x002A94A8
	private bnn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062C4 RID: 25284 RVA: 0x002AB2B4 File Offset: 0x002A94B4
	public override bool tq()
	{
		return true;
	}

	// Token: 0x060062C5 RID: 25285 RVA: 0x002AB2B8 File Offset: 0x002A94B8
	public override string tr()
	{
		return "HeartbreakPoisonBearTrap";
	}

	// Token: 0x060062C6 RID: 25286 RVA: 0x002AB2C0 File Offset: 0x002A94C0
	public bnn(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062C7 RID: 25287 RVA: 0x002AB2D0 File Offset: 0x002A94D0
	protected override void ts(amc A_0, amc A_1, cwt A_2, List<csk> A_3)
	{
		if (A_1.aa().Passive || A_1.aa().b(d8o.e) || A_1.aa().d(CharacterImmunities.Poison))
		{
			if (A_0 != null)
			{
				etm a_ = new etm(new ap9(A_1.aa()), "яду");
				bey.a(a_, A_0.aa(), A_1.aa(), A_1);
				a7v.a(a_);
			}
			bmj.a(A_1.a8(), new ba0());
			return;
		}
		int num = ezx.v;
		if (A_0 != null && A_0.aa().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0.aa())));
		}
		ef5 ef = new ef5((A_0 != null) ? A_0.aa() : null, ezx.y * d0u.b, num);
		ef.Stacks = ezx.z;
		A_1.aa().StatusEffects.a(ef, false, false, false);
	}
}
