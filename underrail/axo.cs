using System;
using System.Runtime.Serialization;

// Token: 0x02001B33 RID: 6963
[eiz("PSE1")]
[Serializable]
public sealed class axo : els, ISerializable
{
	// Token: 0x06009693 RID: 38547 RVA: 0x003AE1DC File Offset: 0x003AC3DC
	private axo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetValue("PSE1:O", typeof(object));
	}

	// Token: 0x06009694 RID: 38548 RVA: 0x003AE204 File Offset: 0x003AC404
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PSE1:O", this.b);
	}

	// Token: 0x1700027E RID: 638
	// (get) Token: 0x06009695 RID: 38549 RVA: 0x003AE220 File Offset: 0x003AC420
	public object ObjectOfFear
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x1700027F RID: 639
	// (get) Token: 0x06009696 RID: 38550 RVA: 0x003AE228 File Offset: 0x003AC428
	public override bool Refreshable
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06009697 RID: 38551 RVA: 0x003AE230 File Offset: 0x003AC430
	public axo(int A_0, object A_1) : base(axo.a, "Страх", ci8.c)
	{
		this.b = A_1;
		base.Icon = "Status.Fear";
		base.ExpiredAction = "PanicExpiresAction";
		base.RemovedAction = "PanicExpiresAction";
		base.VisualEffects.Add(new ud(this, "Fear"));
		base.Duration = A_0;
		base.StaticEffects.Add(new bdx());
	}

	// Token: 0x06009698 RID: 38552 RVA: 0x003AE2A4 File Offset: 0x003AC4A4
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Fear");
	}

	// Token: 0x040039ED RID: 14829
	public new static readonly string a = "fear";

	// Token: 0x040039EE RID: 14830
	private object b;
}
