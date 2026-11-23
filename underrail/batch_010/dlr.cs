using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Vehicles;

// Token: 0x02001959 RID: 6489
[eiz("VFI")]
[Serializable]
public sealed class dlr : b81, ISerializable
{
	// Token: 0x06008A8C RID: 35468 RVA: 0x0038D234 File Offset: 0x0038B434
	private dlr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (bws)A_0.GetValue("VFI:V", typeof(bws));
		this.b = A_0.GetDouble("VFI:C");
		this.c = A_0.GetInt32("VFI:D");
		this.d = A_0.GetDouble("VFI:T");
		this.f = A_0.GetDouble("VFI:S");
		this.g = (d8o)A_0.GetValue("VFI:A", typeof(d8o));
		di7.ReadList<du2>("VFI:R", ref this.h, A_0);
		if (ell.a() >= 372)
		{
			this.i = A_0.GetString("VFI:M");
		}
		if (ell.a() >= 511)
		{
			this.e = A_0.GetDouble("VFI:N");
		}
	}

	// Token: 0x06008A8D RID: 35469 RVA: 0x0038D370 File Offset: 0x0038B570
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VFI:V", this.a);
		info.AddValue("VFI:C", this.b);
		info.AddValue("VFI:D", this.c);
		info.AddValue("VFI:T", this.d);
		info.AddValue("VFI:S", this.f);
		info.AddValue("VFI:A", this.g);
		di7.WriteList<du2>("VFI:R", this.h, info);
		info.AddValue("VFI:M", this.i);
		info.AddValue("VFI:N", this.e);
	}

	// Token: 0x06008A8E RID: 35470 RVA: 0x0038D428 File Offset: 0x0038B628
	public bws c()
	{
		return this.a;
	}

	// Token: 0x06008A8F RID: 35471 RVA: 0x0038D430 File Offset: 0x0038B630
	public new void a(bws A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008A90 RID: 35472 RVA: 0x0038D43C File Offset: 0x0038B63C
	public override VehiclePartType qp()
	{
		return VehiclePartType.Frame;
	}

	// Token: 0x06008A91 RID: 35473 RVA: 0x0038D440 File Offset: 0x0038B640
	public new List<du2> a()
	{
		return this.h;
	}

	// Token: 0x06008A92 RID: 35474 RVA: 0x0038D448 File Offset: 0x0038B648
	public double f()
	{
		return this.b;
	}

	// Token: 0x06008A93 RID: 35475 RVA: 0x0038D450 File Offset: 0x0038B650
	public void b(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008A94 RID: 35476 RVA: 0x0038D45C File Offset: 0x0038B65C
	public int d()
	{
		return this.c;
	}

	// Token: 0x06008A95 RID: 35477 RVA: 0x0038D464 File Offset: 0x0038B664
	public new void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008A96 RID: 35478 RVA: 0x0038D470 File Offset: 0x0038B670
	public double e()
	{
		return this.d;
	}

	// Token: 0x06008A97 RID: 35479 RVA: 0x0038D478 File Offset: 0x0038B678
	public new void a(double A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06008A98 RID: 35480 RVA: 0x0038D484 File Offset: 0x0038B684
	public double i()
	{
		return this.e;
	}

	// Token: 0x06008A99 RID: 35481 RVA: 0x0038D48C File Offset: 0x0038B68C
	public void d(double A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06008A9A RID: 35482 RVA: 0x0038D498 File Offset: 0x0038B698
	public double g()
	{
		return this.f;
	}

	// Token: 0x06008A9B RID: 35483 RVA: 0x0038D4A0 File Offset: 0x0038B6A0
	public void c(double A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06008A9C RID: 35484 RVA: 0x0038D4AC File Offset: 0x0038B6AC
	public d8o b()
	{
		return this.g;
	}

	// Token: 0x06008A9D RID: 35485 RVA: 0x0038D4B4 File Offset: 0x0038B6B4
	public new void a(d8o A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06008A9E RID: 35486 RVA: 0x0038D4C0 File Offset: 0x0038B6C0
	public string h()
	{
		return this.i;
	}

	// Token: 0x06008A9F RID: 35487 RVA: 0x0038D4C8 File Offset: 0x0038B6C8
	public new void a(string A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06008AA0 RID: 35488 RVA: 0x0038D4D4 File Offset: 0x0038B6D4
	public dlr()
	{
	}

	// Token: 0x06008AA1 RID: 35489 RVA: 0x0038D53C File Offset: 0x0038B73C
	public override void qq(bcx A_0, agt A_1)
	{
		base.qq(A_0, A_1);
		A_0.a(this.a);
		A_0.a(A_0.s() | this.g);
		A_0.e(A_0.ad() + this.b);
		A_0.h(A_0.v() + this.c);
		A_0.f(A_0.n() + this.f);
		A_0.j(this.d);
		A_0.g(this.e);
		A_0.d(this.i);
		foreach (du2 a_ in this.h)
		{
			A_0.a(a_);
		}
	}

	// Token: 0x06008AA2 RID: 35490 RVA: 0x0038D61C File Offset: 0x0038B81C
	public override bk3 tw()
	{
		dlr dlr = new dlr();
		this.ai7(dlr);
		return dlr;
	}

	// Token: 0x06008AA3 RID: 35491 RVA: 0x0038D638 File Offset: 0x0038B838
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		dlr dlr = (dlr)A_0;
		dlr.a = this.a;
		dlr.b = this.b;
		dlr.h = new List<du2>(this.h);
		dlr.c = this.c;
		dlr.f = this.f;
		dlr.d = this.d;
		dlr.e = this.e;
		dlr.g = this.g;
		dlr.i = this.i;
	}

	// Token: 0x0400370F RID: 14095
	private new bws a;

	// Token: 0x04003710 RID: 14096
	private double b = 0.3;

	// Token: 0x04003711 RID: 14097
	private int c = 300;

	// Token: 0x04003712 RID: 14098
	private double d = 0.65;

	// Token: 0x04003713 RID: 14099
	private double e = 0.7;

	// Token: 0x04003714 RID: 14100
	private double f = 1.0;

	// Token: 0x04003715 RID: 14101
	private d8o g;

	// Token: 0x04003716 RID: 14102
	private new List<du2> h = new List<du2>();

	// Token: 0x04003717 RID: 14103
	private string i;
}
