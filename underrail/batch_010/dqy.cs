using System;
using System.Runtime.Serialization;

// Token: 0x02001A33 RID: 6707
[eiz("M50")]
[Serializable]
public sealed class dqy : d3e, ISerializable
{
	// Token: 0x06009155 RID: 37205 RVA: 0x0039CACC File Offset: 0x0039ACCC
	private dqy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("M50:A");
	}

	// Token: 0x06009156 RID: 37206 RVA: 0x0039CAE8 File Offset: 0x0039ACE8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("M50:A", this.a);
	}

	// Token: 0x06009157 RID: 37207 RVA: 0x0039CB04 File Offset: 0x0039AD04
	public double a()
	{
		return this.a;
	}

	// Token: 0x06009158 RID: 37208 RVA: 0x0039CB0C File Offset: 0x0039AD0C
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009159 RID: 37209 RVA: 0x0039CB18 File Offset: 0x0039AD18
	public override bool ae5()
	{
		return this.a > 0.0;
	}

	// Token: 0x0600915A RID: 37210 RVA: 0x0039CB2C File Offset: 0x0039AD2C
	public dqy()
	{
	}

	// Token: 0x0600915B RID: 37211 RVA: 0x0039CB34 File Offset: 0x0039AD34
	public dqy(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600915C RID: 37212 RVA: 0x0039CB44 File Offset: 0x0039AD44
	protected override void @in(ll A_0)
	{
		dcu dcu = A_0.a().Offense;
		dcu.i(dcu.y() + this.a);
	}

	// Token: 0x0600915D RID: 37213 RVA: 0x0039CB70 File Offset: 0x0039AD70
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((dqy)A_0).a = this.a;
	}

	// Token: 0x0600915E RID: 37214 RVA: 0x0039CB8C File Offset: 0x0039AD8C
	public override string b2()
	{
		if (this.a >= 0.0)
		{
			return qv.a("StaticEffects/ModifyFirearmReloadingSpeed_Increased", new object[]
			{
				(int)(this.a * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyFirearmReloadingSpeed_Decreased", new object[]
		{
			(int)(Math.Abs(this.a) * 100.0)
		});
	}

	// Token: 0x0600915F RID: 37215 RVA: 0x0039CC08 File Offset: 0x0039AE08
	public override d3e b3()
	{
		dqy dqy = new dqy();
		this.xx(dqy);
		return dqy;
	}

	// Token: 0x04003826 RID: 14374
	public new double a;
}
