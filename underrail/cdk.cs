using System;
using System.Runtime.Serialization;

// Token: 0x0200192A RID: 6442
[eiz("QSI")]
[elw(typeof(acz))]
[Serializable]
public class cdk : bk3, ISerializable
{
	// Token: 0x060088B8 RID: 35000 RVA: 0x00388510 File Offset: 0x00386710
	protected cdk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(cdk);
		}
	}

	// Token: 0x060088B9 RID: 35001 RVA: 0x0038853C File Offset: 0x0038673C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060088BA RID: 35002 RVA: 0x00388548 File Offset: 0x00386748
	public override string tv()
	{
		return "Боевой инструмент";
	}

	// Token: 0x060088BB RID: 35003 RVA: 0x00388554 File Offset: 0x00386754
	public override bk3 tw()
	{
		cdk cdk = new cdk();
		this.ai7(cdk);
		return cdk;
	}

	// Token: 0x060088BC RID: 35004 RVA: 0x00388570 File Offset: 0x00386770
	public cdk()
	{
	}
}
