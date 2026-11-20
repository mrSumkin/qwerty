using System;
using System.Runtime.Serialization;

// Token: 0x02001956 RID: 6486
[eiz("VSI")]
[Serializable]
public abstract class dv2 : b81, ISerializable
{
	// Token: 0x06008A71 RID: 35441 RVA: 0x0038CF0C File Offset: 0x0038B10C
	protected dv2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("VSI:S");
	}

	// Token: 0x06008A72 RID: 35442 RVA: 0x0038CF28 File Offset: 0x0038B128
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VSI:S", this.a);
	}

	// Token: 0x06008A73 RID: 35443 RVA: 0x0038CF44 File Offset: 0x0038B144
	public new double a()
	{
		return this.a;
	}

	// Token: 0x06008A74 RID: 35444 RVA: 0x0038CF4C File Offset: 0x0038B14C
	public new void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008A75 RID: 35445 RVA: 0x0038CF58 File Offset: 0x0038B158
	public dv2()
	{
	}

	// Token: 0x06008A76 RID: 35446 RVA: 0x0038CF60 File Offset: 0x0038B160
	public override void qq(bcx A_0, agt A_1)
	{
		base.qq(A_0, A_1);
		A_0.j(A_0.aa() + this.a);
	}

	// Token: 0x06008A77 RID: 35447 RVA: 0x0038CF80 File Offset: 0x0038B180
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		((dv2)A_0).a = this.a;
	}

	// Token: 0x0400370A RID: 14090
	private new double a;
}
