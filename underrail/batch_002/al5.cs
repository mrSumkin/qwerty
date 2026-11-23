using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Vehicles;

// Token: 0x02001953 RID: 6483
[eiz("VAI")]
[Serializable]
public sealed class al5 : b81, ISerializable
{
	// Token: 0x06008A57 RID: 35415 RVA: 0x0038CC60 File Offset: 0x0038AE60
	private al5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (VehiclePartType)A_0.GetValue("VAI:A", typeof(VehiclePartType));
	}

	// Token: 0x06008A58 RID: 35416 RVA: 0x0038CC8C File Offset: 0x0038AE8C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VAI:A", this.a);
	}

	// Token: 0x06008A59 RID: 35417 RVA: 0x0038CCAC File Offset: 0x0038AEAC
	public override VehiclePartType qp()
	{
		return this.a;
	}

	// Token: 0x06008A5A RID: 35418 RVA: 0x0038CCB4 File Offset: 0x0038AEB4
	public new VehiclePartType a()
	{
		return this.a;
	}

	// Token: 0x06008A5B RID: 35419 RVA: 0x0038CCBC File Offset: 0x0038AEBC
	public new void a(VehiclePartType A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008A5C RID: 35420 RVA: 0x0038CCC8 File Offset: 0x0038AEC8
	public al5()
	{
	}

	// Token: 0x06008A5D RID: 35421 RVA: 0x0038CCD0 File Offset: 0x0038AED0
	public override void qq(bcx A_0, agt A_1)
	{
	}

	// Token: 0x06008A5E RID: 35422 RVA: 0x0038CCD8 File Offset: 0x0038AED8
	public override bk3 tw()
	{
		al5 al = new al5();
		this.ai7(al);
		return al;
	}

	// Token: 0x06008A5F RID: 35423 RVA: 0x0038CCF4 File Offset: 0x0038AEF4
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		((al5)A_0).a = this.a;
	}

	// Token: 0x04003706 RID: 14086
	private new VehiclePartType a;
}
