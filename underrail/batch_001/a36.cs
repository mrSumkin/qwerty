using System;
using System.Runtime.Serialization;

// Token: 0x02001AA1 RID: 6817
[eiz("CUSE")]
[Serializable]
public sealed class a36 : els, ISerializable
{
	// Token: 0x060093EA RID: 37866 RVA: 0x003A44A4 File Offset: 0x003A26A4
	private a36(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.e = (A_0.GetValue("CUSE:E", typeof(l5)) as l5);
		this.f = (A_0.GetValue("CUSE:A", typeof(d9)) as d9);
	}

	// Token: 0x060093EB RID: 37867 RVA: 0x003A44FC File Offset: 0x003A26FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CUSE:E", this.e);
		info.AddValue("CUSE:A", this.f);
	}

	// Token: 0x060093EC RID: 37868 RVA: 0x003A4528 File Offset: 0x003A2728
	public a36() : this(a36.d)
	{
	}

	// Token: 0x060093ED RID: 37869 RVA: 0x003A4538 File Offset: 0x003A2738
	public a36(int A_0) : base("carvedUp", "Нашинкованный", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.CarvedUp";
		base.MaxStacks = a36.a;
		base.Stacking = axm.b;
		this.e = new l5((double)base.Stacks * a36.b);
		this.f = new d9(base.Stacks * -a36.c, true, false);
		base.StaticEffects.Add(this.e);
		base.StaticEffects.Add(this.f);
	}

	// Token: 0x060093EE RID: 37870 RVA: 0x003A45D0 File Offset: 0x003A27D0
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/CarvedUp", new object[]
		{
			Math.Abs(this.f.Amount),
			(int)(this.e.Modifier * 100.0)
		});
	}

	// Token: 0x060093EF RID: 37871 RVA: 0x003A4624 File Offset: 0x003A2824
	protected override void c8()
	{
		this.e.Modifier = (double)base.Stacks * a36.b;
		this.f.Amount = base.Stacks * -a36.c;
	}

	// Token: 0x040038D4 RID: 14548
	public new static readonly int a = 5;

	// Token: 0x040038D5 RID: 14549
	public static readonly double b = 0.03;

	// Token: 0x040038D6 RID: 14550
	public new static readonly int c = 2;

	// Token: 0x040038D7 RID: 14551
	public new static readonly int d = 3 * d0u.b;

	// Token: 0x040038D8 RID: 14552
	private new l5 e;

	// Token: 0x040038D9 RID: 14553
	private d9 f;
}
