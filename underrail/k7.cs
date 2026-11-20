using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001947 RID: 6471
[eiz("HII")]
[Serializable]
public sealed class k7 : cgk, IItemInstance<bqu>, ISerializable
{
	// Token: 0x060089B6 RID: 35254 RVA: 0x0038AE2C File Offset: 0x0038902C
	private k7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(k7);
		}
	}

	// Token: 0x060089B7 RID: 35255 RVA: 0x0038AE58 File Offset: 0x00389058
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060089B8 RID: 35256 RVA: 0x0038AE64 File Offset: 0x00389064
	public new bqu fu()
	{
		return base.Definition as bqu;
	}

	// Token: 0x060089B9 RID: 35257 RVA: 0x0038AE74 File Offset: 0x00389074
	public k7(bit A_0) : base(A_0)
	{
	}

	// Token: 0x060089BA RID: 35258 RVA: 0x0038AE80 File Offset: 0x00389080
	public override coh fy()
	{
		k7 k = new k7(base.DefinitionProvider.wm());
		this.fz(k);
		return k;
	}
}
