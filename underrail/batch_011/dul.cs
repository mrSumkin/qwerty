using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000530 RID: 1328
[eiz("QE")]
[Serializable]
public abstract class dul : c47, ISerializable
{
	// Token: 0x06002210 RID: 8720 RVA: 0x000B4DF8 File Offset: 0x000B2FF8
	protected dul(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (eei)A_0.GetValue("QE:Q", typeof(eei));
	}

	// Token: 0x06002211 RID: 8721 RVA: 0x000B4E24 File Offset: 0x000B3024
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("QE:Q", this.a);
	}

	// Token: 0x06002212 RID: 8722 RVA: 0x000B4E40 File Offset: 0x000B3040
	public bool c()
	{
		return true;
	}

	// Token: 0x06002213 RID: 8723 RVA: 0x000B4E44 File Offset: 0x000B3044
	public eei e()
	{
		return this.a;
	}

	// Token: 0x06002214 RID: 8724 RVA: 0x000B4E4C File Offset: 0x000B304C
	protected dul(eei A_0)
	{
		czh.a(A_0, "quest");
		this.a = A_0;
	}

	// Token: 0x06002215 RID: 8725 RVA: 0x000B4E68 File Offset: 0x000B3068
	public List<string> d()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString()
		};
	}

	// Token: 0x06002216 RID: 8726
	public abstract ecs h6();

	// Token: 0x06002217 RID: 8727 RVA: 0x000B4E90 File Offset: 0x000B3090
	public ecs g()
	{
		return this.h6();
	}

	// Token: 0x06002218 RID: 8728 RVA: 0x000B4E9C File Offset: 0x000B309C
	public int? f()
	{
		return null;
	}

	// Token: 0x0400146C RID: 5228
	private eei a;
}
