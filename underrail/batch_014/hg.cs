using System;
using System.Runtime.Serialization;

// Token: 0x02001269 RID: 4713
[eiz("CHGEA")]
[Serializable]
public sealed class hg : cry, ISerializable, chb, c98
{
	// Token: 0x0600662B RID: 26155 RVA: 0x002B7210 File Offset: 0x002B5410
	private hg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600662C RID: 26156 RVA: 0x002B721C File Offset: 0x002B541C
	public override string gv()
	{
		return "chemhazeGas";
	}

	// Token: 0x0600662D RID: 26157 RVA: 0x002B7224 File Offset: 0x002B5424
	public override bool gw()
	{
		return true;
	}

	// Token: 0x0600662E RID: 26158 RVA: 0x002B7228 File Offset: 0x002B5428
	public hg(c5x A_0, string A_1, Guid? A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x0600662F RID: 26159 RVA: 0x002B7234 File Offset: 0x002B5434
	public override void gx(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().b(d8o.e) && cuo.a.NextDouble() < 0.75)
		{
			A_0.h.b.aa().StatusEffects.a(new dyv(dyv.e * d0u.b), false, false, false);
		}
	}

	// Token: 0x06006630 RID: 26160 RVA: 0x002B72D4 File Offset: 0x002B54D4
	protected override void gy(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().b(d8o.e))
		{
			int a_ = base.f() / 2 + 1;
			A_0.h.b.aa().StatusEffects.a(new dyv(dyv.e * d0u.b)
			{
				Stacks = a_
			}, false, false, false);
		}
	}
}
