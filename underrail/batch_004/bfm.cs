using System;
using System.Runtime.Serialization;

// Token: 0x02001A89 RID: 6793
[eiz("5AC")]
[Serializable]
public sealed class bfm : els, ISerializable
{
	// Token: 0x0600937C RID: 37756 RVA: 0x003A2904 File Offset: 0x003A0B04
	private bfm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.d = (A_0.GetValue("5AC:E", typeof(b2g)) as b2g);
	}

	// Token: 0x0600937D RID: 37757 RVA: 0x003A2930 File Offset: 0x003A0B30
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("5AC:E", this.d);
	}

	// Token: 0x0600937E RID: 37758 RVA: 0x003A2950 File Offset: 0x003A0B50
	public bfm(int A_0) : base("anticoagulation", "Антикоагуляция", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.Anticoagulation";
		base.MaxStacks = bfm.c;
		base.Stacking = axm.b;
		this.d = new b2g();
		this.d.Value = bfm.a * (double)base.Stacks;
		base.StaticEffects.Add(this.d);
		base.DynamicEffects.Add(new e85());
	}

	// Token: 0x0600937F RID: 37759 RVA: 0x003A29D8 File Offset: 0x003A0BD8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Anticoagulation", new object[]
		{
			(int)((double)base.Stacks * bfm.b * 100.0),
			(int)Math.Abs((double)base.Stacks * bfm.a * 100.0)
		});
	}

	// Token: 0x06009380 RID: 37760 RVA: 0x003A2A3C File Offset: 0x003A0C3C
	protected override void c8()
	{
		this.d.Value = bfm.a * (double)base.Stacks;
	}

	// Token: 0x040038A6 RID: 14502
	public new static readonly double a = -0.07;

	// Token: 0x040038A7 RID: 14503
	public static readonly double b = 0.2;

	// Token: 0x040038A8 RID: 14504
	public new static readonly int c = 10;

	// Token: 0x040038A9 RID: 14505
	private new b2g d;
}
