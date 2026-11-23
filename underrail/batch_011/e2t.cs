using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001406 RID: 5126
[eiz("CASTDA")]
[Serializable]
public sealed class e2t : b1z, ISerializable
{
	// Token: 0x06007329 RID: 29481 RVA: 0x00308AF0 File Offset: 0x00306CF0
	private e2t(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("CASTDA:T", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.b = (A_0.GetValue("CASTDA:A", typeof(ap9)) as ap9);
		this.c = (a1q)A_0.GetValue("CASTDA:M", typeof(a1q));
		this.d = (a1q)A_0.GetValue("CASTDA:E", typeof(a1q));
	}

	// Token: 0x0600732A RID: 29482 RVA: 0x00308B88 File Offset: 0x00306D88
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CASTDA:T", this.a);
		info.AddValue("CASTDA:A", this.b);
		info.AddValue("CASTDA:M", this.c);
		info.AddValue("CASTDA:E", this.d);
	}

	// Token: 0x0600732B RID: 29483 RVA: 0x00308BEC File Offset: 0x00306DEC
	public e2t(EntityAspectReference<amc, amc> A_0, ap9 A_1, a1q A_2, a1q A_3)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x0600732C RID: 29484 RVA: 0x00308C14 File Offset: 0x00306E14
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a != null && this.a.ao() != null)
		{
			int a_ = ed3.k * d0u.b;
			double a_2 = c7h.a(this.a.ao().aa(), ref a_);
			bha a_3 = new bha(a_, this.b, this.c, this.d, a_2, false, 0.0);
			this.a.ao().aa().StatusEffects.a(a_3, false, false, false);
		}
		return dc4.c;
	}

	// Token: 0x04002F0E RID: 12046
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002F0F RID: 12047
	private ap9 b;

	// Token: 0x04002F10 RID: 12048
	private a1q c;

	// Token: 0x04002F11 RID: 12049
	private a1q d;
}
