using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020011F3 RID: 4595
[eiz("BPBTT")]
[Serializable]
public sealed class czk : azv, ISerializable
{
	// Token: 0x060062B8 RID: 25272 RVA: 0x002AAC84 File Offset: 0x002A8E84
	private czk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062B9 RID: 25273 RVA: 0x002AAC90 File Offset: 0x002A8E90
	public override bool tq()
	{
		return true;
	}

	// Token: 0x060062BA RID: 25274 RVA: 0x002AAC94 File Offset: 0x002A8E94
	public override string tr()
	{
		return "BlindingPoisonBearTrap";
	}

	// Token: 0x060062BB RID: 25275 RVA: 0x002AAC9C File Offset: 0x002A8E9C
	public czk(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062BC RID: 25276 RVA: 0x002AACAC File Offset: 0x002A8EAC
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
		int num = ezx.l;
		if (A_0 != null && A_0.aa().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0.aa())));
		}
		vs vs = new vs((A_0 != null) ? A_0.aa() : null, ezx.o * d0u.b, num);
		vs.Stacks = ezx.p;
		A_1.aa().StatusEffects.a(vs, false, false, false);
	}
}
