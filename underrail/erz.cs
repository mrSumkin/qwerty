using System;
using System.Runtime.Serialization;

// Token: 0x020019D5 RID: 6613
[eiz("CSMF")]
[Serializable]
public sealed class erz : cdh, ISerializable, d7s
{
	// Token: 0x06008DC9 RID: 36297 RVA: 0x003940E8 File Offset: 0x003922E8
	private erz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("CSMF:M");
	}

	// Token: 0x06008DCA RID: 36298 RVA: 0x00394104 File Offset: 0x00392304
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSMF:M", this.a);
	}

	// Token: 0x1700022F RID: 559
	// (get) Token: 0x06008DCB RID: 36299 RVA: 0x00394120 File Offset: 0x00392320
	// (set) Token: 0x06008DCC RID: 36300 RVA: 0x00394128 File Offset: 0x00392328
	public double DamageBonus
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x17000230 RID: 560
	// (get) Token: 0x06008DCD RID: 36301 RVA: 0x00394134 File Offset: 0x00392334
	public override bool Negative
	{
		get
		{
			return this.a < 0.0;
		}
	}

	// Token: 0x06008DCE RID: 36302 RVA: 0x00394148 File Offset: 0x00392348
	public erz()
	{
	}

	// Token: 0x06008DCF RID: 36303 RVA: 0x00394154 File Offset: 0x00392354
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Урон от Калечащего удара уменьшен на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
		}
		return string.Format("Урон от Калечащего удара увеличен на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
	}

	// Token: 0x06008DD0 RID: 36304 RVA: 0x003941C8 File Offset: 0x003923C8
	public override d3e b3()
	{
		erz erz = new erz();
		this.xx(erz);
		return erz;
	}

	// Token: 0x06008DD1 RID: 36305 RVA: 0x003941E4 File Offset: 0x003923E4
	public void cn(d3e A_0)
	{
		erz erz = A_0 as erz;
		if (erz != null)
		{
			this.a += erz.a;
		}
	}

	// Token: 0x06008DD2 RID: 36306 RVA: 0x00394214 File Offset: 0x00392414
	public bool co(d3e A_0)
	{
		return A_0 is erz;
	}

	// Token: 0x06008DD3 RID: 36307 RVA: 0x00394220 File Offset: 0x00392420
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((erz)A_0).a = this.a;
	}

	// Token: 0x040037C4 RID: 14276
	private new double a;
}
