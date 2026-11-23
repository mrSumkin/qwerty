using System;
using System.Runtime.Serialization;

// Token: 0x02001813 RID: 6163
[eiz("FCAGA")]
[Serializable]
public sealed class d3z : d64, ISerializable
{
	// Token: 0x06008312 RID: 33554 RVA: 0x0036DAC0 File Offset: 0x0036BCC0
	private d3z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008313 RID: 33555 RVA: 0x0036DACC File Offset: 0x0036BCCC
	public d3z()
	{
	}

	// Token: 0x06008314 RID: 33556 RVA: 0x0036DAD4 File Offset: 0x0036BCD4
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.d() != null)
		{
			ewy ewy = ckf.a("humanFusionCannon") as ewy;
			if (ewy != null)
			{
				ewy.a(base.c(), base.d(), cd, cd.CurrentBullet, null);
				return true;
			}
		}
		return false;
	}
}
