using System;
using System.Runtime.Serialization;

// Token: 0x020019FE RID: 6654
[eiz("M60")]
[Serializable]
public sealed class edw : d3e, ISerializable
{
	// Token: 0x06008F8A RID: 36746 RVA: 0x003980A4 File Offset: 0x003962A4
	private edw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("M60:A");
	}

	// Token: 0x06008F8B RID: 36747 RVA: 0x003980C0 File Offset: 0x003962C0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("M60:A", this.a);
	}

	// Token: 0x06008F8C RID: 36748 RVA: 0x003980DC File Offset: 0x003962DC
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008F8D RID: 36749 RVA: 0x003980E4 File Offset: 0x003962E4
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F8E RID: 36750 RVA: 0x003980F0 File Offset: 0x003962F0
	public override bool ae5()
	{
		return this.a > 0.0;
	}

	// Token: 0x06008F8F RID: 36751 RVA: 0x00398104 File Offset: 0x00396304
	public edw()
	{
	}

	// Token: 0x06008F90 RID: 36752 RVA: 0x0039810C File Offset: 0x0039630C
	public edw(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F91 RID: 36753 RVA: 0x00398120 File Offset: 0x00396320
	protected override void @in(ll A_0)
	{
		dcu dcu = A_0.a().Offense;
		dcu.a(dcu.at() + this.a);
	}

	// Token: 0x06008F92 RID: 36754 RVA: 0x0039814C File Offset: 0x0039634C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((edw)A_0).a = this.a;
	}

	// Token: 0x06008F93 RID: 36755 RVA: 0x00398168 File Offset: 0x00396368
	public override string b2()
	{
		if (this.a >= 0.0)
		{
			return qv.a("StaticEffects/ModifyBulletReloadingSpeed_Increased", new object[]
			{
				(int)(this.a * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyBulletReloadingSpeed_Decreased", new object[]
		{
			(int)(Math.Abs(this.a) * 100.0)
		});
	}

	// Token: 0x06008F94 RID: 36756 RVA: 0x003981E4 File Offset: 0x003963E4
	public override d3e b3()
	{
		edw edw = new edw();
		this.xx(edw);
		return edw;
	}

	// Token: 0x040037F8 RID: 14328
	public new double a;
}
