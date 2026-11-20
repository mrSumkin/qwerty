using System;
using System.Runtime.Serialization;

// Token: 0x0200192F RID: 6447
[eiz("DSI")]
[Serializable]
public sealed class ak0 : dfg, ISerializable
{
	// Token: 0x060088CD RID: 35021 RVA: 0x003886CC File Offset: 0x003868CC
	private ak0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(ak0);
		}
	}

	// Token: 0x060088CE RID: 35022 RVA: 0x003886F8 File Offset: 0x003868F8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060088CF RID: 35023 RVA: 0x00388704 File Offset: 0x00386904
	public override string tv()
	{
		return "Документ";
	}

	// Token: 0x060088D0 RID: 35024 RVA: 0x0038870C File Offset: 0x0038690C
	public override string pu()
	{
		return "Document:";
	}

	// Token: 0x060088D1 RID: 35025 RVA: 0x00388714 File Offset: 0x00386914
	public ak0()
	{
		base.f(true);
	}

	// Token: 0x060088D2 RID: 35026 RVA: 0x00388724 File Offset: 0x00386924
	public ak0(cqh A_0) : base(A_0)
	{
		base.f(true);
	}

	// Token: 0x060088D3 RID: 35027 RVA: 0x00388738 File Offset: 0x00386938
	public override bk3 tw()
	{
		ak0 ak = new ak0();
		this.ai7(ak);
		return ak;
	}
}
