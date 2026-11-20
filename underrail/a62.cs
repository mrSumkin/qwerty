using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020017DC RID: 6108
[eiz("CSIA")]
[Serializable]
public sealed class a62 : ad5, ISerializable
{
	// Token: 0x06008221 RID: 33313 RVA: 0x0036C4EC File Offset: 0x0036A6EC
	private a62(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008222 RID: 33314 RVA: 0x0036C4F8 File Offset: 0x0036A6F8
	protected override m7 d6()
	{
		return m7.a;
	}

	// Token: 0x06008223 RID: 33315 RVA: 0x0036C4FC File Offset: 0x0036A6FC
	public a62(eu7 A_0, c5x A_1, object A_2) : base(A_0, A_1, A_2, false)
	{
	}

	// Token: 0x06008224 RID: 33316 RVA: 0x0036C508 File Offset: 0x0036A708
	public override pl d7()
	{
		return new xb(this);
	}

	// Token: 0x06008225 RID: 33317 RVA: 0x0036C510 File Offset: 0x0036A710
	public override boa d8(afq A_0, params evd[] A_1)
	{
		return new d5r(this, A_0, A_1);
	}

	// Token: 0x06008226 RID: 33318 RVA: 0x0036C51C File Offset: 0x0036A71C
	public override List<cst> ea(dqw A_0)
	{
		return new List<cst>
		{
			new e4t(base.q().h.b, CharacterState.Operating, dz6.b(cux.e), 0, null, 1)
		};
	}

	// Token: 0x06008227 RID: 33319 RVA: 0x0036C560 File Offset: 0x0036A760
	protected override c47 ec()
	{
		string a_ = "Unknown";
		coh coh = base.e().b9() as coh;
		if (coh != null && coh.Definition != null)
		{
			if (coh.Definition is avz || coh.Definition is dfg)
			{
				return null;
			}
			a_ = coh.Definition.az();
		}
		return new a0m(new ap9(base.e().b8()), a_, base.e().p().Nature);
	}
}
