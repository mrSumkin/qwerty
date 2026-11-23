using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A8A RID: 6794
[eiz("BRSE")]
[Serializable]
public sealed class e8b : els, ISerializable
{
	// Token: 0x06009382 RID: 37762 RVA: 0x003A2A80 File Offset: 0x003A0C80
	private e8b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("BRSE:E", typeof(e3r)) as e3r);
		if (ell.a() >= 393)
		{
			this.c = A_0.GetDouble("BRSE:B");
		}
	}

	// Token: 0x06009383 RID: 37763 RVA: 0x003A2AD8 File Offset: 0x003A0CD8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BRSE:E", this.b);
		info.AddValue("BRSE:B", this.c);
	}

	// Token: 0x06009384 RID: 37764 RVA: 0x003A2B08 File Offset: 0x003A0D08
	public e8b(double A_0) : base(e8b.a, "Сломанное ребро", ci8.c)
	{
		this.c = A_0;
		base.MaxStacks = bsx.c;
		base.Duration = bsx.d * d0u.b;
		base.Icon = "Status.BrokenRib";
		base.Power = Convert.ToInt32(A_0 * 100.0);
		this.b = new e3r(DamageType.Mechanical, (bsx.b + this.c) * (double)base.Stacks);
		base.StaticEffects.Add(this.b);
	}

	// Token: 0x06009385 RID: 37765 RVA: 0x003A2B9C File Offset: 0x003A0D9C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/BrokenRib", new object[]
		{
			(int)(this.b.Value * 100.0)
		});
	}

	// Token: 0x06009386 RID: 37766 RVA: 0x003A2BCC File Offset: 0x003A0DCC
	protected override void c8()
	{
		this.b.Value = (bsx.b + this.c) * (double)base.Stacks;
	}

	// Token: 0x040038AA RID: 14506
	public new static readonly string a = "brokenRib";

	// Token: 0x040038AB RID: 14507
	private e3r b;

	// Token: 0x040038AC RID: 14508
	private new double c;
}
