using System;
using System.Runtime.Serialization;

// Token: 0x020019BA RID: 6586
[eiz("MGLRSE")]
[Serializable]
public sealed class cim : d3e, ISerializable
{
	// Token: 0x06008CEE RID: 36078 RVA: 0x003922BC File Offset: 0x003904BC
	private cim(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MGLRSE:A");
	}

	// Token: 0x06008CEF RID: 36079 RVA: 0x003922D8 File Offset: 0x003904D8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MGLRSE:A", this.a);
	}

	// Token: 0x06008CF0 RID: 36080 RVA: 0x003922F4 File Offset: 0x003904F4
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008CF1 RID: 36081 RVA: 0x003922FC File Offset: 0x003904FC
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008CF2 RID: 36082 RVA: 0x00392308 File Offset: 0x00390508
	public override bool ae5()
	{
		return this.a > 0.0;
	}

	// Token: 0x06008CF3 RID: 36083 RVA: 0x0039231C File Offset: 0x0039051C
	public cim()
	{
	}

	// Token: 0x06008CF4 RID: 36084 RVA: 0x00392324 File Offset: 0x00390524
	public cim(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008CF5 RID: 36085 RVA: 0x00392338 File Offset: 0x00390538
	protected override void @in(ll A_0)
	{
		dcu dcu = A_0.a().Offense;
		dcu.f(dcu.ac() + this.a);
	}

	// Token: 0x06008CF6 RID: 36086 RVA: 0x00392364 File Offset: 0x00390564
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((cim)A_0).a = this.a;
	}

	// Token: 0x06008CF7 RID: 36087 RVA: 0x00392380 File Offset: 0x00390580
	public override string b2()
	{
		if (this.a >= 0.0)
		{
			return qv.a("StaticEffects/ModifyGrenadeLauncherReloadingSpeed_Increased", new object[]
			{
				(int)(this.a * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyGrenadeLauncherReloadingSpeed_Decreased", new object[]
		{
			(int)(Math.Abs(this.a) * 100.0)
		});
	}

	// Token: 0x06008CF8 RID: 36088 RVA: 0x003923FC File Offset: 0x003905FC
	public override d3e b3()
	{
		cim cim = new cim();
		this.xx(cim);
		return cim;
	}

	// Token: 0x040037AD RID: 14253
	public new double a;
}
