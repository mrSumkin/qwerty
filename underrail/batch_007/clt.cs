using System;
using System.Runtime.Serialization;

// Token: 0x02001B30 RID: 6960
[eiz("S09")]
[Serializable]
public sealed class clt : els, ISerializable
{
	// Token: 0x06009684 RID: 38532 RVA: 0x003ADE40 File Offset: 0x003AC040
	private clt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009685 RID: 38533 RVA: 0x003ADE4C File Offset: 0x003AC04C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x1700027D RID: 637
	// (get) Token: 0x06009686 RID: 38534 RVA: 0x003ADE58 File Offset: 0x003AC058
	public override bool Refreshable
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06009687 RID: 38535 RVA: 0x003ADE5C File Offset: 0x003AC05C
	public clt(int A_0) : base(clt.a, "Короткое замыкание", ci8.c)
	{
		base.Icon = "Status.ShortCircuited";
		base.VisualEffects.Add(new ud(this, "Electricity"));
		base.AppliedAction = "ScAppliedAction";
		base.ExpiredAction = "ScExpiresAction";
		base.RemovedAction = "ScExpiresAction";
		this.w = "SC8";
		this.x = "SC9";
		base.Duration = A_0;
		base.StaticEffects.Add(new a1s());
	}

	// Token: 0x06009688 RID: 38536 RVA: 0x003ADEEC File Offset: 0x003AC0EC
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/ShortCircuited");
	}

	// Token: 0x040039E9 RID: 14825
	public new static readonly string a = "shortCircuited";
}
