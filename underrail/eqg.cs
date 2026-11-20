using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Vehicles;

// Token: 0x02001958 RID: 6488
[eiz("VEI")]
[Serializable]
public sealed class eqg : b81, ISerializable
{
	// Token: 0x06008A7D RID: 35453 RVA: 0x0038D010 File Offset: 0x0038B210
	private eqg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("VEI:P");
		this.b = A_0.GetDouble("VEI:C");
		this.c = A_0.GetString("VEI:S");
		this.d = A_0.GetSingle("VEI:V");
	}

	// Token: 0x06008A7E RID: 35454 RVA: 0x0038D080 File Offset: 0x0038B280
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VEI:P", this.a);
		info.AddValue("VEI:C", this.b);
		info.AddValue("VEI:S", this.c);
		info.AddValue("VEI:V", this.d);
	}

	// Token: 0x06008A7F RID: 35455 RVA: 0x0038D0DC File Offset: 0x0038B2DC
	public override VehiclePartType qp()
	{
		return VehiclePartType.Engine;
	}

	// Token: 0x06008A80 RID: 35456 RVA: 0x0038D0E0 File Offset: 0x0038B2E0
	public int b()
	{
		return this.a;
	}

	// Token: 0x06008A81 RID: 35457 RVA: 0x0038D0E8 File Offset: 0x0038B2E8
	public new void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008A82 RID: 35458 RVA: 0x0038D0F4 File Offset: 0x0038B2F4
	public double d()
	{
		return this.b;
	}

	// Token: 0x06008A83 RID: 35459 RVA: 0x0038D0FC File Offset: 0x0038B2FC
	public new void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008A84 RID: 35460 RVA: 0x0038D108 File Offset: 0x0038B308
	public new string a()
	{
		return this.c;
	}

	// Token: 0x06008A85 RID: 35461 RVA: 0x0038D110 File Offset: 0x0038B310
	public new void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008A86 RID: 35462 RVA: 0x0038D11C File Offset: 0x0038B31C
	public float c()
	{
		return this.d;
	}

	// Token: 0x06008A87 RID: 35463 RVA: 0x0038D124 File Offset: 0x0038B324
	public new void a(float A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06008A88 RID: 35464 RVA: 0x0038D130 File Offset: 0x0038B330
	public eqg()
	{
	}

	// Token: 0x06008A89 RID: 35465 RVA: 0x0038D150 File Offset: 0x0038B350
	public override void qq(bcx A_0, agt A_1)
	{
		base.qq(A_0, A_1);
		A_0.g(A_0.i() + this.a);
		A_0.d(A_0.ab() + (int)((double)this.a * this.b));
		if (!string.IsNullOrEmpty(this.c))
		{
			A_0.a(A_1.Id.ToString(), "vehicleEngine_" + this.c, this.d);
		}
	}

	// Token: 0x06008A8A RID: 35466 RVA: 0x0038D1D4 File Offset: 0x0038B3D4
	public override bk3 tw()
	{
		eqg eqg = new eqg();
		this.ai7(eqg);
		return eqg;
	}

	// Token: 0x06008A8B RID: 35467 RVA: 0x0038D1F0 File Offset: 0x0038B3F0
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		eqg eqg = (eqg)A_0;
		eqg.b = this.b;
		eqg.a = this.a;
		eqg.c = this.c;
		eqg.d = this.d;
	}

	// Token: 0x0400370B RID: 14091
	private new int a = 100;

	// Token: 0x0400370C RID: 14092
	private double b = 1.0;

	// Token: 0x0400370D RID: 14093
	private string c;

	// Token: 0x0400370E RID: 14094
	private float d;
}
