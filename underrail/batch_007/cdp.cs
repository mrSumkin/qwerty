using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200140C RID: 5132
[eiz("DRWAA")]
[Serializable]
public sealed class cdp : b1z, ISerializable
{
	// Token: 0x06007341 RID: 29505 RVA: 0x003091A4 File Offset: 0x003073A4
	private cdp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("DRWAA:A", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.b = (A_0.GetValue("DRWAA:T", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.c = (A_0.GetValue("DRWAA:R", typeof(cwt)) as cwt);
		this.d = (A_0.GetValue("DRWAA:W", typeof(cd1)) as cd1);
	}

	// Token: 0x06007342 RID: 29506 RVA: 0x0030923C File Offset: 0x0030743C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DRWAA:A", this.a);
		info.AddValue("DRWAA:T", this.b);
		info.AddValue("DRWAA:R", this.c);
		info.AddValue("DRWAA:W", this.d);
	}

	// Token: 0x06007343 RID: 29507 RVA: 0x00309298 File Offset: 0x00307498
	public cdp(amc A_0, amc A_1, cwt A_2, cd1 A_3)
	{
		this.a = new EntityAspectReference<amc, amc>(A_0);
		this.b = new EntityAspectReference<amc, amc>(A_1);
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x06007344 RID: 29508 RVA: 0x003092C8 File Offset: 0x003074C8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a.ao() != null && this.b.ao() != null && this.c != null && this.d != null)
		{
			awq.a(this.a.ao(), this.b.ao(), this.c, this.d, null, true, null, null, null, false, false, true, null, null);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04002F1E RID: 12062
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002F1F RID: 12063
	private EntityAspectReference<amc, amc> b;

	// Token: 0x04002F20 RID: 12064
	private cwt c;

	// Token: 0x04002F21 RID: 12065
	private cd1 d;
}
