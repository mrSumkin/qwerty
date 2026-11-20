using System;
using System.Runtime.Serialization;

// Token: 0x02001B23 RID: 6947
[eiz("SF0")]
[Serializable]
public sealed class cfb : els, ISerializable
{
	// Token: 0x06009649 RID: 38473 RVA: 0x003AD2D0 File Offset: 0x003AB4D0
	private cfb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600964A RID: 38474 RVA: 0x003AD2E0 File Offset: 0x003AB4E0
	public cfb() : base("strangeFeeling", "Странное ощущение", ci8.c)
	{
		base.Duration = d0u.b * 4;
		base.Icon = "Status.5";
		base.MaxStacks = 5;
		base.Stacking = axm.b;
	}

	// Token: 0x0600964B RID: 38475 RVA: 0x003AD324 File Offset: 0x003AB524
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/StrangeFeeling");
	}
}
