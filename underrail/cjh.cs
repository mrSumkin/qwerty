using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200193D RID: 6461
[eiz("BII1")]
[Serializable]
public sealed class cjh : a06, IItemInstance<c27>, ISerializable
{
	// Token: 0x0600891E RID: 35102 RVA: 0x00389200 File Offset: 0x00387400
	private cjh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(cjh);
		}
	}

	// Token: 0x0600891F RID: 35103 RVA: 0x0038922C File Offset: 0x0038742C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06008920 RID: 35104 RVA: 0x00389238 File Offset: 0x00387438
	public new c27 fu()
	{
		return base.Definition as c27;
	}

	// Token: 0x06008921 RID: 35105 RVA: 0x00389248 File Offset: 0x00387448
	public cjh(bit A_0) : base(A_0)
	{
	}

	// Token: 0x06008922 RID: 35106 RVA: 0x00389254 File Offset: 0x00387454
	public override coh fy()
	{
		cjh cjh = new cjh(base.DefinitionProvider.wm());
		this.fz(cjh);
		return cjh;
	}
}
