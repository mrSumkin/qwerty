using System;
using System.Runtime.Serialization;

// Token: 0x02001466 RID: 5222
[eiz("CPA")]
[Serializable]
public sealed class dvt : dvv, ISerializable
{
	// Token: 0x060075BC RID: 30140 RVA: 0x0031D628 File Offset: 0x0031B828
	private dvt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (av)A_0.GetValue("CPA:P", typeof(av));
			return;
		}
		if (base.GetType() == typeof(dvt))
		{
			this.a = (av)A_0.GetValue("_Proxy", typeof(av));
			return;
		}
		this.a = (av)A_0.GetValue("ConsumeProxyAction+_Proxy", typeof(av));
	}

	// Token: 0x060075BD RID: 30141 RVA: 0x0031D6C4 File Offset: 0x0031B8C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CPA:P", this.a);
	}

	// Token: 0x060075BE RID: 30142 RVA: 0x0031D6E0 File Offset: 0x0031B8E0
	public dvt(av A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060075BF RID: 30143 RVA: 0x0031D6F0 File Offset: 0x0031B8F0
	protected override dc4 dt()
	{
		if (this.a != null)
		{
			this.a.a(false);
		}
		return dc4.c;
	}

	// Token: 0x060075C0 RID: 30144 RVA: 0x0031D70C File Offset: 0x0031B90C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return dc4.e;
	}

	// Token: 0x0400302A RID: 12330
	private new av a;
}
