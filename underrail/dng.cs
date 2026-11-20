using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001919 RID: 6425
[eiz("AI3")]
[Serializable]
public sealed class dng : d48, IItemInstance<dgr>, ISerializable
{
	// Token: 0x0600887F RID: 34943 RVA: 0x00387CD4 File Offset: 0x00385ED4
	private dng(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008880 RID: 34944 RVA: 0x00387CE0 File Offset: 0x00385EE0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x06008881 RID: 34945 RVA: 0x00387CEC File Offset: 0x00385EEC
	[Browsable(false)]
	public dgr TypedDefinition
	{
		get
		{
			return base.Definition as dgr;
		}
	}

	// Token: 0x06008882 RID: 34946 RVA: 0x00387CFC File Offset: 0x00385EFC
	public dng(bit A_0) : base(A_0)
	{
	}

	// Token: 0x06008883 RID: 34947 RVA: 0x00387D08 File Offset: 0x00385F08
	public override coh fy()
	{
		dng dng = new dng(base.DefinitionProvider.wm());
		this.fz(dng);
		return dng;
	}

	// Token: 0x06008884 RID: 34948 RVA: 0x00387D30 File Offset: 0x00385F30
	public override bool anx(efk A_0)
	{
		return A_0 != null && A_0.Bag.h(this);
	}
}
