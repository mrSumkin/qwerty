using System;
using System.Runtime.Serialization;

// Token: 0x020019D6 RID: 6614
[eiz("STHRMF")]
[Serializable]
public sealed class ee5 : cdh, ISerializable, d7s
{
	// Token: 0x06008DD4 RID: 36308 RVA: 0x0039423C File Offset: 0x0039243C
	private ee5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("STHRMF:B");
		this.b = A_0.GetDouble("STHRMF:T");
		this.c = A_0.GetInt32("STHRMF:R");
	}

	// Token: 0x06008DD5 RID: 36309 RVA: 0x00394284 File Offset: 0x00392484
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("STHRMF:B", this.a);
		info.AddValue("STHRMF:T", this.b);
		info.AddValue("STHRMF:R", this.c);
	}

	// Token: 0x06008DD6 RID: 36310 RVA: 0x003942CC File Offset: 0x003924CC
	public double c()
	{
		return this.a;
	}

	// Token: 0x06008DD7 RID: 36311 RVA: 0x003942D4 File Offset: 0x003924D4
	public void b(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008DD8 RID: 36312 RVA: 0x003942E0 File Offset: 0x003924E0
	public double a()
	{
		return this.b;
	}

	// Token: 0x06008DD9 RID: 36313 RVA: 0x003942E8 File Offset: 0x003924E8
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008DDA RID: 36314 RVA: 0x003942F4 File Offset: 0x003924F4
	public int b()
	{
		return this.c;
	}

	// Token: 0x06008DDB RID: 36315 RVA: 0x003942FC File Offset: 0x003924FC
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008DDC RID: 36316 RVA: 0x00394308 File Offset: 0x00392508
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008DDD RID: 36317 RVA: 0x0039431C File Offset: 0x0039251C
	public ee5()
	{
	}

	// Token: 0x06008DDE RID: 36318 RVA: 0x00394324 File Offset: 0x00392524
	public ee5(int A_0, double A_1, double A_2)
	{
		this.c = A_0;
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x06008DDF RID: 36319 RVA: 0x00394344 File Offset: 0x00392544
	public override string b2()
	{
		string format;
		if (this.a < 0.0)
		{
			format = "Дальность броска копья уменьшена на {0}, а базовый урон {1}% и урон за единицу дальности броска на {2}%.";
		}
		else
		{
			format = "Дальность броска копья увеличена на {0}, а базовый урон {1}% и урон за единицу дальности броска на {2}%.";
		}
		return string.Format(format, this.c, Convert.ToInt32(Math.Abs(this.a) * 100.0), Convert.ToInt32(Math.Abs(this.b) * 100.0));
	}

	// Token: 0x06008DE0 RID: 36320 RVA: 0x003943C8 File Offset: 0x003925C8
	public override d3e b3()
	{
		ee5 ee = new ee5();
		this.xx(ee);
		return ee;
	}

	// Token: 0x06008DE1 RID: 36321 RVA: 0x003943E4 File Offset: 0x003925E4
	public void cn(d3e A_0)
	{
		ee5 ee = A_0 as ee5;
		if (ee != null)
		{
			this.a += ee.a;
			this.b += ee.b;
			this.c += ee.c;
		}
	}

	// Token: 0x06008DE2 RID: 36322 RVA: 0x00394438 File Offset: 0x00392638
	public bool co(d3e A_0)
	{
		return A_0 is ee5;
	}

	// Token: 0x06008DE3 RID: 36323 RVA: 0x00394444 File Offset: 0x00392644
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		ee5 ee = (ee5)A_0;
		ee.a = this.a;
		ee.b = this.b;
		ee.c = this.c;
	}

	// Token: 0x040037C5 RID: 14277
	private new double a;

	// Token: 0x040037C6 RID: 14278
	private double b;

	// Token: 0x040037C7 RID: 14279
	private int c;
}
