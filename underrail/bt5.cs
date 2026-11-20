using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200195F RID: 6495
[eiz("DTF")]
[Serializable]
public struct bt5 : ISerializable
{
	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06008ACD RID: 35533 RVA: 0x0038DD6C File Offset: 0x0038BF6C
	// (set) Token: 0x06008ACE RID: 35534 RVA: 0x0038DD74 File Offset: 0x0038BF74
	public DamageType DamageType
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

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06008ACF RID: 35535 RVA: 0x0038DD80 File Offset: 0x0038BF80
	// (set) Token: 0x06008AD0 RID: 35536 RVA: 0x0038DD88 File Offset: 0x0038BF88
	public int BaseDamageThreshold
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

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x06008AD1 RID: 35537 RVA: 0x0038DD94 File Offset: 0x0038BF94
	// (set) Token: 0x06008AD2 RID: 35538 RVA: 0x0038DD9C File Offset: 0x0038BF9C
	public float DamageThresholdIncrement
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

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x06008AD3 RID: 35539 RVA: 0x0038DDA8 File Offset: 0x0038BFA8
	// (set) Token: 0x06008AD4 RID: 35540 RVA: 0x0038DDB0 File Offset: 0x0038BFB0
	public double BaseDamageResistance
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x1700021A RID: 538
	// (get) Token: 0x06008AD5 RID: 35541 RVA: 0x0038DDBC File Offset: 0x0038BFBC
	// (set) Token: 0x06008AD6 RID: 35542 RVA: 0x0038DDC4 File Offset: 0x0038BFC4
	public double DamageResistanceIncrement
	{
		get
		{
			return this.e;
		}
		set
		{
			this.e = value;
		}
	}

	// Token: 0x06008AD7 RID: 35543 RVA: 0x0038DDD0 File Offset: 0x0038BFD0
	public static bool b(bt5 A_0, bt5 A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x06008AD8 RID: 35544 RVA: 0x0038DDE8 File Offset: 0x0038BFE8
	public static bool a(bt5 A_0, bt5 A_1)
	{
		return !A_0.Equals(A_1);
	}

	// Token: 0x06008AD9 RID: 35545 RVA: 0x0038DE00 File Offset: 0x0038C000
	public bt5(DamageType A_0, int A_1, float A_2, double A_3, double A_4)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
	}

	// Token: 0x06008ADA RID: 35546 RVA: 0x0038DE2C File Offset: 0x0038C02C
	public override bool Equals(object obj)
	{
		if (obj is bt5)
		{
			bt5 bt = (bt5)obj;
			return this.a == bt.a && this.b == bt.b && this.c == bt.c && this.d == bt.d && this.e == bt.e;
		}
		return false;
	}

	// Token: 0x06008ADB RID: 35547 RVA: 0x0038DEA4 File Offset: 0x0038C0A4
	public override int GetHashCode()
	{
		return this.a.GetHashCode() + this.b.GetHashCode() + this.c.GetHashCode() + this.d.GetHashCode() + this.e.GetHashCode();
	}

	// Token: 0x06008ADC RID: 35548 RVA: 0x0038DEF4 File Offset: 0x0038C0F4
	private bt5(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() >= 3)
		{
			this.c = A_0.GetSingle("V");
			this.a = (DamageType)A_0.GetValue("T", typeof(DamageType));
		}
		else
		{
			this.c = A_0.GetSingle("_Value");
			this.a = (DamageType)A_0.GetValue("_DamageType", typeof(DamageType));
		}
		if (ell.a() >= 89)
		{
			this.d = A_0.GetDouble("A");
			this.e = A_0.GetDouble("B");
			this.b = A_0.GetInt32("C");
			return;
		}
		this.d = 0.0;
		this.e = 0.0;
		this.b = 0;
	}

	// Token: 0x06008ADD RID: 35549 RVA: 0x0038DFD8 File Offset: 0x0038C1D8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("C", this.b);
		info.AddValue("V", this.c);
		info.AddValue("A", this.d);
		info.AddValue("B", this.e);
		info.AddValue("T", this.a);
	}

	// Token: 0x0400377A RID: 14202
	private DamageType a;

	// Token: 0x0400377B RID: 14203
	private int b;

	// Token: 0x0400377C RID: 14204
	private float c;

	// Token: 0x0400377D RID: 14205
	private double d;

	// Token: 0x0400377E RID: 14206
	private double e;
}
