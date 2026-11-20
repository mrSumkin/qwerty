using System;
using System.Runtime.Serialization;

// Token: 0x02001B00 RID: 6912
[eiz("INH")]
[Serializable]
public sealed class adg : els, ISerializable
{
	// Token: 0x060095B0 RID: 38320 RVA: 0x003AAE9C File Offset: 0x003A909C
	private adg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x17000278 RID: 632
	// (get) Token: 0x060095B1 RID: 38321 RVA: 0x003AAEA8 File Offset: 0x003A90A8
	public override bool Refreshable
	{
		get
		{
			return false;
		}
	}

	// Token: 0x060095B2 RID: 38322 RVA: 0x003AAEAC File Offset: 0x003A90AC
	public adg(int A_0) : base("inhibited", "Подавление", ci8.c)
	{
		base.Icon = "Status.Inhibited";
		base.VisualEffects.Add(new ud(this, "Inhibited"));
		base.ExpiredAction = "RedExpirationAction";
		base.RemovedAction = "RedExpirationAction";
		base.Duration = A_0;
		base.StaticEffects.Add(new acl());
	}

	// Token: 0x060095B3 RID: 38323 RVA: 0x003AAF18 File Offset: 0x003A9118
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Inhibited");
	}
}
