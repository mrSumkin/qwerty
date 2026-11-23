using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001943 RID: 6467
[eiz("SEII")]
[Serializable]
public sealed class cgd : a06, IItemInstance<b3n>, ISerializable
{
	// Token: 0x06008940 RID: 35136 RVA: 0x00389714 File Offset: 0x00387914
	private cgd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(cgd);
		}
	}

	// Token: 0x06008941 RID: 35137 RVA: 0x00389740 File Offset: 0x00387940
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06008942 RID: 35138 RVA: 0x0038974C File Offset: 0x0038794C
	[Browsable(false)]
	public b3n TypedDefinition
	{
		get
		{
			return base.Definition as b3n;
		}
	}

	// Token: 0x06008943 RID: 35139 RVA: 0x0038975C File Offset: 0x0038795C
	public cgd(bit A_0) : base(A_0)
	{
	}

	// Token: 0x06008944 RID: 35140 RVA: 0x00389768 File Offset: 0x00387968
	public override coh fy()
	{
		cgd cgd = new cgd(base.DefinitionProvider.wm());
		this.fz(cgd);
		return cgd;
	}
}
