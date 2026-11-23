using System;
using System.Runtime.Serialization;

// Token: 0x02001A95 RID: 6805
[eiz("CSE01")]
[Serializable]
public sealed class da6 : els, ISerializable
{
	// Token: 0x060093AF RID: 37807 RVA: 0x003A3854 File Offset: 0x003A1A54
	private da6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 496)
		{
			this.b = A_0.GetDouble("CSE01:D");
			this.c = A_0.GetBoolean("CSE01:S");
			return;
		}
		this.Stun = true;
	}

	// Token: 0x060093B0 RID: 37808 RVA: 0x003A38A4 File Offset: 0x003A1AA4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSE01:D", this.b);
		info.AddValue("CSE01:S", this.c);
	}

	// Token: 0x17000271 RID: 625
	// (get) Token: 0x060093B1 RID: 37809 RVA: 0x003A38D0 File Offset: 0x003A1AD0
	// (set) Token: 0x060093B2 RID: 37810 RVA: 0x003A38D8 File Offset: 0x003A1AD8
	public double BonusDamage
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

	// Token: 0x17000272 RID: 626
	// (get) Token: 0x060093B3 RID: 37811 RVA: 0x003A38E4 File Offset: 0x003A1AE4
	// (set) Token: 0x060093B4 RID: 37812 RVA: 0x003A38EC File Offset: 0x003A1AEC
	public bool Stun
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x060093B5 RID: 37813 RVA: 0x003A38F8 File Offset: 0x003A1AF8
	public da6(float A_0, int A_1, double A_2, bool A_3) : base(da6.a, "Атака с разбега", ci8.b)
	{
		base.Icon = "Sprint";
		base.Power = (int)(A_2 * 100.0);
		this.b = A_2;
		this.c = A_3;
		base.StaticEffects.Add(new i0(A_0, true, false, false));
		base.StaticEffects.Add(new ba(A_1, true, false, false));
	}

	// Token: 0x060093B6 RID: 37814 RVA: 0x003A396C File Offset: 0x003A1B6C
	public override string cb(ll A_0)
	{
		if (this.c)
		{
			return qv.a("StatusEffects/Charging", new object[]
			{
				(base.StaticEffects[1] as ba).a,
				(int)(this.b * 100.0)
			});
		}
		return qv.a("StatusEffects/ChargingWithStun", new object[]
		{
			(base.StaticEffects[1] as ba).a,
			(int)(this.b * 100.0)
		});
	}

	// Token: 0x040038C0 RID: 14528
	public new static readonly string a = "charging";

	// Token: 0x040038C1 RID: 14529
	private double b;

	// Token: 0x040038C2 RID: 14530
	private new bool c;
}
