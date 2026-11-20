using System;
using System.Runtime.Serialization;

// Token: 0x02001AFA RID: 6906
[eiz("DF5")]
[Serializable]
public sealed class cpy : els, ISerializable
{
	// Token: 0x06009594 RID: 38292 RVA: 0x003AAAB0 File Offset: 0x003A8CB0
	private cpy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("DF5:D");
	}

	// Token: 0x06009595 RID: 38293 RVA: 0x003AAACC File Offset: 0x003A8CCC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DF5:D", this.b);
	}

	// Token: 0x06009596 RID: 38294 RVA: 0x003AAAE8 File Offset: 0x003A8CE8
	public double a()
	{
		return this.b;
	}

	// Token: 0x06009597 RID: 38295 RVA: 0x003AAAF4 File Offset: 0x003A8CF4
	public cpy(double A_0, int A_1) : base(cpy.a, "Поле помех", ci8.c)
	{
		base.Duration = A_1;
		base.Icon = "Psi.DisruptiveField";
		base.VisualEffects.Add(new ud(this, "DisruptiveField"));
		base.Stacking = axm.b;
		this.ab = "DS0";
		this.y = "ZS0";
		this.aa = "ZS0";
		this.w = "DS0";
		this.x = "ZS0";
		this.b = A_0;
		base.Power = (int)(this.b * 100.0);
		base.StaticEffects.Add(new etj(-this.b));
		base.StaticEffects.Add(new yt(-this.b));
	}

	// Token: 0x06009598 RID: 38296 RVA: 0x003AABC4 File Offset: 0x003A8DC4
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/DisruptiveField", new object[]
		{
			(int)(this.b * 100.0)
		});
	}

	// Token: 0x04003998 RID: 14744
	public new static readonly string a = "disruptiveField";

	// Token: 0x04003999 RID: 14745
	private double b;
}
