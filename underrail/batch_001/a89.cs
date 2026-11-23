using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200140B RID: 5131
[eiz("DMAA")]
[Serializable]
public sealed class a89 : b1z, ISerializable
{
	// Token: 0x0600733B RID: 29499 RVA: 0x00308FD4 File Offset: 0x003071D4
	private a89(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("DMAA:A", typeof(EntityAspectReference<amc, amc>));
		this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("DMAA:T", typeof(EntityAspectReference<amc, amc>));
		this.c = (A_0.GetValue("DMAA:R", typeof(cwt)) as cwt);
		this.d = (A_0.GetValue("DMAA:W", typeof(cd1)) as cd1);
		this.e = (A_0.GetValue("DMAA:C", typeof(enp)) as enp);
	}

	// Token: 0x0600733C RID: 29500 RVA: 0x0030908C File Offset: 0x0030728C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DMAA:A", this.a);
		info.AddValue("DMAA:T", this.b);
		info.AddValue("DMAA:R", this.c);
		info.AddValue("DMAA:W", this.d);
		info.AddValue("DMAA:C", this.e);
	}

	// Token: 0x0600733D RID: 29501 RVA: 0x003090F8 File Offset: 0x003072F8
	private amc b()
	{
		return this.a.ao();
	}

	// Token: 0x0600733E RID: 29502 RVA: 0x00309108 File Offset: 0x00307308
	private amc a()
	{
		return this.b.ao();
	}

	// Token: 0x0600733F RID: 29503 RVA: 0x00309118 File Offset: 0x00307318
	public a89(amc A_0, amc A_1, cwt A_2, cd1 A_3, enp A_4 = null)
	{
		czh.a(A_0, "attacker");
		czh.a(A_1, "target");
		this.a = new EntityAspectReference<amc, amc>(A_0);
		this.b = new EntityAspectReference<amc, amc>(A_1);
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
	}

	// Token: 0x06007340 RID: 29504 RVA: 0x00309170 File Offset: 0x00307370
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		awq.a(this.b(), this.a(), this.c, this.d, this.e);
		return dc4.c;
	}

	// Token: 0x04002F19 RID: 12057
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002F1A RID: 12058
	private EntityAspectReference<amc, amc> b;

	// Token: 0x04002F1B RID: 12059
	private cwt c;

	// Token: 0x04002F1C RID: 12060
	private cd1 d;

	// Token: 0x04002F1D RID: 12061
	private enp e;
}
