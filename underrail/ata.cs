using System;
using System.Runtime.Serialization;

// Token: 0x02001B07 RID: 6919
[eiz("WBD")]
[Serializable]
public sealed class ata : els, ISerializable
{
	// Token: 0x060095CE RID: 38350 RVA: 0x003AB6FC File Offset: 0x003A98FC
	private ata(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 516)
		{
			this.b = A_0.GetBoolean("WBD:F");
		}
	}

	// Token: 0x060095CF RID: 38351 RVA: 0x003AB728 File Offset: 0x003A9928
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("WBD:F", this.b);
	}

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x060095D0 RID: 38352 RVA: 0x003AB744 File Offset: 0x003A9944
	public bool FineWeb
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x060095D1 RID: 38353 RVA: 0x003AB750 File Offset: 0x003A9950
	public ata(int A_0, bool A_1 = false) : base(ata.a, "Паучья сеть", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.39";
		base.VisualEffects.Add(new ud(this, "WebEntanglement"));
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		this.b = A_1;
		base.StaticEffects.Add(new ap0());
	}

	// Token: 0x060095D2 RID: 38354 RVA: 0x003AB7BC File Offset: 0x003A99BC
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Webbed");
	}

	// Token: 0x040039A9 RID: 14761
	public new static readonly string a = "webbed";

	// Token: 0x040039AA RID: 14762
	private bool b;
}
