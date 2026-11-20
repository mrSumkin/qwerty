using System;
using System.Runtime.Serialization;

// Token: 0x0200023F RID: 575
[eiz("SLA")]
[Serializable]
public sealed class e4b : axv, a9q, bvq, ISerializable
{
	// Token: 0x06001040 RID: 4160 RVA: 0x000437B0 File Offset: 0x000419B0
	private e4b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetBoolean("SLA:A");
			this.b = (ego)A_0.GetValue("SLA:E", typeof(ego));
			this.c = A_0.GetInt32("SLA:L");
			return;
		}
		if (base.GetType() == typeof(e4b))
		{
			this.a = A_0.GetBoolean("_Attached");
			this.b = (ego)A_0.GetValue("_Emitter", typeof(ego));
			this.c = A_0.GetInt32("_Layer");
			return;
		}
		this.a = A_0.GetBoolean("SoftLightArea+_Attached");
		this.b = (ego)A_0.GetValue("SoftLightArea+_Emitter", typeof(ego));
		this.c = A_0.GetInt32("SoftLightArea+_Layer");
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x000438B4 File Offset: 0x00041AB4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SLA:A", this.a);
		info.AddValue("SLA:E", this.b);
		info.AddValue("SLA:L", this.c);
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x000438FC File Offset: 0x00041AFC
	public int m4()
	{
		return this.c;
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x00043904 File Offset: 0x00041B04
	public void m5(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x00043910 File Offset: 0x00041B10
	public ego b()
	{
		return this.b;
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x00043918 File Offset: 0x00041B18
	public override bool af7()
	{
		return this.b != null && this.b.Enabled;
	}

	// Token: 0x06001046 RID: 4166 RVA: 0x00043934 File Offset: 0x00041B34
	internal e4b(aud A_0, string A_1) : base(A_1, A_0)
	{
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x00043940 File Offset: 0x00041B40
	internal e4b(aud A_0, Guid A_1, string A_2) : base(A_1, A_2, A_0)
	{
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x0004394C File Offset: 0x00041B4C
	public void a(ego A_0)
	{
		czh.a(A_0, "emitter");
		if (this.a)
		{
			this.a();
		}
		this.b = A_0;
		this.b.a(this);
		this.a = true;
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x00043984 File Offset: 0x00041B84
	public void a()
	{
		this.f();
		if (this.b != null)
		{
			this.b.b(this);
		}
		this.c();
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x000439AC File Offset: 0x00041BAC
	public override void af8()
	{
		base.af8();
		this.a();
		base.h().SoftLightAreas.c(this);
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x000439D8 File Offset: 0x00041BD8
	internal void c()
	{
		this.a = false;
		this.b = null;
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x000439EC File Offset: 0x00041BEC
	protected override void af9(ak1 A_0)
	{
		czh.a(A_0, "tile");
		A_0.a(new c3y(base.qe(), this.b(), dqc.b));
		A_0.e();
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x00043A24 File Offset: 0x00041C24
	protected override void aga(ak1 A_0)
	{
		czh.a(A_0, "tile");
		A_0.a(base.qe());
		A_0.e();
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x00043A44 File Offset: 0x00041C44
	protected override void agb(ak1 A_0)
	{
		czh.a(A_0, "tile");
		A_0.e();
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x00043A58 File Offset: 0x00041C58
	protected override bool agc()
	{
		return true;
	}

	// Token: 0x04000975 RID: 2421
	private new bool a;

	// Token: 0x04000976 RID: 2422
	private ego b;

	// Token: 0x04000977 RID: 2423
	private int c;
}
