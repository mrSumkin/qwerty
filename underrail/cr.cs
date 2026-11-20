using System;
using System.Runtime.Serialization;

// Token: 0x02001B3A RID: 6970
[eiz("MSSE")]
[Serializable]
public sealed class cr : els, ISerializable
{
	// Token: 0x060096BB RID: 38587 RVA: 0x003AEA54 File Offset: 0x003ACC54
	private cr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("MSSE:MRE", typeof(cly)) as cly);
	}

	// Token: 0x060096BC RID: 38588 RVA: 0x003AEA80 File Offset: 0x003ACC80
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSSE:MRE", this.b);
	}

	// Token: 0x060096BD RID: 38589 RVA: 0x003AEAA0 File Offset: 0x003ACCA0
	public cr() : base(cr.a, "Ментальная диверсия", ci8.c)
	{
		base.Duration = cgu.c;
		base.Icon = "Status.5";
		base.MaxStacks = cgu.b;
		base.Stacking = axm.b;
		this.b = new cly(0f)
		{
			Priority = 2147483646
		};
		base.StaticEffects.Add(this.b);
		this.a();
	}

	// Token: 0x060096BE RID: 38590 RVA: 0x003AEB18 File Offset: 0x003ACD18
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/MentalSubversion", new object[]
		{
			-Convert.ToInt32(this.b.c() * 100f)
		});
	}

	// Token: 0x060096BF RID: 38591 RVA: 0x003AEB4C File Offset: 0x003ACD4C
	protected override void c8()
	{
		base.c8();
		this.a();
	}

	// Token: 0x060096C0 RID: 38592 RVA: 0x003AEB5C File Offset: 0x003ACD5C
	protected override void dp()
	{
		base.dp();
		this.a();
	}

	// Token: 0x060096C1 RID: 38593 RVA: 0x003AEB6C File Offset: 0x003ACD6C
	private void a()
	{
		this.b.a(-(float)Math.Max(0.009999999776482582, cgu.a / (double)cgu.b * (double)base.Stacks));
	}

	// Token: 0x040039FA RID: 14842
	public new static readonly string a = "mentalSubversion";

	// Token: 0x040039FB RID: 14843
	private cly b;
}
