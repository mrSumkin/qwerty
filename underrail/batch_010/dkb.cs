using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000532 RID: 1330
[eiz("IE")]
[Serializable]
public abstract class dkb : c47, b2h, ISerializable
{
	// Token: 0x0600221D RID: 8733 RVA: 0x000B4F58 File Offset: 0x000B3158
	protected dkb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (coh)A_0.GetValue("IE:I", typeof(coh));
			return;
		}
		if (base.GetType() == typeof(dkb))
		{
			this.a = (coh)A_0.GetValue("_Item", typeof(coh));
			return;
		}
		this.a = (coh)A_0.GetValue("ItemEvent+_Item", typeof(coh));
	}

	// Token: 0x0600221E RID: 8734 RVA: 0x000B4FF4 File Offset: 0x000B31F4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("IE:I", this.a);
	}

	// Token: 0x0600221F RID: 8735 RVA: 0x000B5010 File Offset: 0x000B3210
	public bool a()
	{
		return false;
	}

	// Token: 0x06002220 RID: 8736 RVA: 0x000B5014 File Offset: 0x000B3214
	public coh c()
	{
		return this.a;
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x000B501C File Offset: 0x000B321C
	protected dkb(coh A_0)
	{
		czh.a(A_0, "item");
		this.a = A_0;
	}

	// Token: 0x06002222 RID: 8738 RVA: 0x000B5038 File Offset: 0x000B3238
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x06002223 RID: 8739
	public abstract ecs se();

	// Token: 0x06002224 RID: 8740 RVA: 0x000B5074 File Offset: 0x000B3274
	protected void a(dl6 A_0)
	{
		A_0.a.AddRange(b94.a(this.c()));
	}

	// Token: 0x0400146D RID: 5229
	private coh a;
}
