using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A08 RID: 6664
[eiz("HWE")]
[Serializable]
public sealed class bii : d3e, ISerializable
{
	// Token: 0x06008FE3 RID: 36835 RVA: 0x00398F00 File Offset: 0x00397100
	private bii(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008FE4 RID: 36836 RVA: 0x00398F0C File Offset: 0x0039710C
	public bii()
	{
	}

	// Token: 0x06008FE5 RID: 36837 RVA: 0x00398F18 File Offset: 0x00397118
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null && (euf.d(A_0.a().Offense.u().TypedDefinition).GetValueOrDefault() == WeaponSubtype.Sledgehammer || euf.o(A_0.a().Offense.u()) || euf.n(A_0.a().Offense.u())))
		{
			dcu dcu = A_0.a().Offense;
			dcu.g(dcu.am() + Math.Max(0.0, A_0.a().Defense.aj()) * (1.0 + (double)A_0.a().GetSpecializationValue<b3h>(true) * b3h.a));
		}
	}

	// Token: 0x06008FE6 RID: 36838 RVA: 0x00398FEC File Offset: 0x003971EC
	public override d3e b3()
	{
		bii bii = new bii();
		this.xx(bii);
		return bii;
	}
}
