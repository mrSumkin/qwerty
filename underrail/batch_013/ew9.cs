using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001327 RID: 4903
[eiz("SSAA2")]
[Serializable]
public sealed class ew9 : dvv, ISerializable
{
	// Token: 0x06006F1A RID: 28442 RVA: 0x002EAE10 File Offset: 0x002E9010
	private ew9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("SSAA2:S", typeof(EntityAspectReference<ny, ny>)) as EntityAspectReference<ny, ny>);
		this.b = (atp)A_0.GetValue("SSAA2:T", typeof(atp));
		this.c = (A_0.GetValue("SSAA2:A", typeof(cst)) as cst);
	}

	// Token: 0x06006F1B RID: 28443 RVA: 0x002EAE88 File Offset: 0x002E9088
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSAA2:S", this.a);
		info.AddValue("SSAA2:T", this.b);
		info.AddValue("SSAA2:A", this.c);
	}

	// Token: 0x06006F1C RID: 28444 RVA: 0x002EAED8 File Offset: 0x002E90D8
	public ew9(EntityAspectReference<ny, ny> A_0, cst A_1, atp A_2 = atp.a)
	{
		this.a = A_0;
		this.b = A_2;
		this.c = A_1;
	}

	// Token: 0x06006F1D RID: 28445 RVA: 0x002EAEF8 File Offset: 0x002E90F8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a != null && this.a.ao() != null && this.c != null)
		{
			this.a.ao().b(this.c, this.b);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04002D73 RID: 11635
	private new EntityAspectReference<ny, ny> a;

	// Token: 0x04002D74 RID: 11636
	private atp b;

	// Token: 0x04002D75 RID: 11637
	private cst c;
}
