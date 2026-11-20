using System;
using System.Runtime.Serialization;

// Token: 0x02001B38 RID: 6968
[eiz("HYPSE")]
[Serializable]
public sealed class e6y : els, ISerializable
{
	// Token: 0x060096B1 RID: 38577 RVA: 0x003AE710 File Offset: 0x003AC910
	private e6y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (ax6)A_0.GetValue("HYPSE:MCE", typeof(ax6));
	}

	// Token: 0x060096B2 RID: 38578 RVA: 0x003AE73C File Offset: 0x003AC93C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("HYPSE:MCE", this.b);
	}

	// Token: 0x060096B3 RID: 38579 RVA: 0x003AE758 File Offset: 0x003AC958
	public e6y(int A_0, int A_1) : base(e6y.a, "Гипотермия", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = 0;
		base.Icon = "Status.Hypothermia";
		base.MaxStacks = A_1;
		base.Stacking = axm.b;
		this.b = new ax6("Constitution", -qz.a);
		base.StaticEffects.Add(this.b);
	}

	// Token: 0x060096B4 RID: 38580 RVA: 0x003AE7C4 File Offset: 0x003AC9C4
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Hypothermia", new object[]
		{
			-this.b.c()
		});
	}

	// Token: 0x060096B5 RID: 38581 RVA: 0x003AE7EC File Offset: 0x003AC9EC
	protected override void c8()
	{
		this.b.a(base.Stacks * -qz.a);
	}

	// Token: 0x040039F6 RID: 14838
	public new static readonly string a = "hypothermia";

	// Token: 0x040039F7 RID: 14839
	private ax6 b;
}
