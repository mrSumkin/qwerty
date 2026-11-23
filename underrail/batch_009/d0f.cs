using System;
using System.Runtime.Serialization;

// Token: 0x02001B0D RID: 6925
[eiz("YTD")]
[Serializable]
public sealed class d0f : els, ISerializable
{
	// Token: 0x060095E9 RID: 38377 RVA: 0x003ABC18 File Offset: 0x003A9E18
	private d0f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("YTD:D");
		if (ell.a() >= 601)
		{
			this.c = A_0.GetDouble("YTD:P");
		}
	}

	// Token: 0x060095EA RID: 38378 RVA: 0x003ABC54 File Offset: 0x003A9E54
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("YTD:D", this.b);
		info.AddValue("YTD:P", this.c);
	}

	// Token: 0x1700027A RID: 634
	// (get) Token: 0x060095EB RID: 38379 RVA: 0x003ABC80 File Offset: 0x003A9E80
	// (set) Token: 0x060095EC RID: 38380 RVA: 0x003ABC88 File Offset: 0x003A9E88
	public int Damage
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x060095ED RID: 38381 RVA: 0x003ABC94 File Offset: 0x003A9E94
	public d0f(int A_0, int A_1, double A_2) : base(d0f.a, "Термодинамическая дестабилизация", ci8.c)
	{
		this.b = A_1;
		this.c = A_2;
		base.Power = A_1;
		base.Duration = A_0;
		base.TickPeriod = 0;
		base.Icon = "Psi.ThermodynamicDestabilization";
		base.VisualEffects.Add(new ud(this, "Smoking"));
		base.Stacking = axm.b;
		this.ab = "SM0";
		this.y = "SM1";
		this.aa = "SM1";
		this.w = "SM0";
		this.x = "SM1";
	}

	// Token: 0x060095EE RID: 38382 RVA: 0x003ABD34 File Offset: 0x003A9F34
	public override string cb(ll A_0)
	{
		csk[] array = aph.b(this.b);
		string text = qv.a("StatusEffects/ThermodynamicDestabilization", new object[]
		{
			array[0].a(true),
			array[1].a(true)
		});
		if (this.c > 0.0)
		{
			text = text + " " + qv.a("Psi/ThermodynamicDestabilizationPyromaniac", new object[]
			{
				(int)(aph.g * 100.0),
				(int)(this.c * 100.0),
				l4.a(3, false)
			});
		}
		return text;
	}

	// Token: 0x040039B3 RID: 14771
	public new static readonly string a = "thermodynamicDestabilization";

	// Token: 0x040039B4 RID: 14772
	private int b;

	// Token: 0x040039B5 RID: 14773
	public new double c;
}
