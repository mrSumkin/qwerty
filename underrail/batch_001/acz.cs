using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200194B RID: 6475
[eiz("QSII")]
[Serializable]
public class acz : coh, IItemInstance<cdk>, ISerializable
{
	// Token: 0x06008A13 RID: 35347 RVA: 0x0038C03C File Offset: 0x0038A23C
	protected acz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(acz);
		}
	}

	// Token: 0x06008A14 RID: 35348 RVA: 0x0038C068 File Offset: 0x0038A268
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06008A15 RID: 35349 RVA: 0x0038C074 File Offset: 0x0038A274
	public cdk fu()
	{
		return base.Definition as cdk;
	}

	// Token: 0x06008A16 RID: 35350 RVA: 0x0038C084 File Offset: 0x0038A284
	public acz(bit A_0) : base(A_0)
	{
	}

	// Token: 0x06008A17 RID: 35351 RVA: 0x0038C090 File Offset: 0x0038A290
	public override coh fy()
	{
		acz acz = new acz(base.DefinitionProvider.wm());
		this.fz(acz);
		return acz;
	}

	// Token: 0x06008A18 RID: 35352 RVA: 0x0038C0B8 File Offset: 0x0038A2B8
	public override bool anx(efk A_0)
	{
		return A_0 != null && A_0.Gear.a(this);
	}
}
