using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001409 RID: 5129
[eiz("TWHIEA")]
[Serializable]
public sealed class yl : b1z, ISerializable
{
	// Token: 0x06007333 RID: 29491 RVA: 0x00308D6C File Offset: 0x00306F6C
	private yl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("TWHIEA:S", typeof(EntityAspectReference<amc, amc>));
		this.b = (A_0.GetValue("TWHIEA:W", typeof(Guid?)) as Guid?);
		this.c = A_0.GetBoolean("TWHIEA:T");
	}

	// Token: 0x06007334 RID: 29492 RVA: 0x00308DD8 File Offset: 0x00306FD8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TWHIEA:S", this.a);
		info.AddValue("TWHIEA:W", this.b);
		info.AddValue("TWHIEA:T", this.c);
	}

	// Token: 0x06007335 RID: 29493 RVA: 0x00308E28 File Offset: 0x00307028
	public yl(amc A_0, cd1 A_1, bool A_2)
	{
		czh.a(A_0, "subject");
		this.a = new EntityAspectReference<amc, amc>(A_0);
		if (A_1 != null)
		{
			this.b = new Guid?(A_1.Id);
		}
		this.c = A_2;
	}

	// Token: 0x06007336 RID: 29494 RVA: 0x00308E68 File Offset: 0x00307068
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a.ao() != null)
		{
			bk0.a(this.a.ao().aa(), this.b, this.c);
		}
		return dc4.c;
	}

	// Token: 0x04002F13 RID: 12051
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002F14 RID: 12052
	private Guid? b;

	// Token: 0x04002F15 RID: 12053
	private bool c;
}
