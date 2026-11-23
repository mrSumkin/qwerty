using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001A68 RID: 6760
[eiz("MDVRM")]
[Serializable]
public sealed class aqg : bns, ISerializable
{
	// Token: 0x060092D2 RID: 37586 RVA: 0x003A02B0 File Offset: 0x0039E4B0
	private aqg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MDVRM:V");
	}

	// Token: 0x060092D3 RID: 37587 RVA: 0x003A02CC File Offset: 0x0039E4CC
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("MDVRM:V", this.a);
	}

	// Token: 0x060092D4 RID: 37588 RVA: 0x003A02E8 File Offset: 0x0039E4E8
	public double a()
	{
		return this.a;
	}

	// Token: 0x060092D5 RID: 37589 RVA: 0x003A02F0 File Offset: 0x0039E4F0
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060092D6 RID: 37590 RVA: 0x003A02FC File Offset: 0x0039E4FC
	public override bool hx()
	{
		return this.a < 0.0;
	}

	// Token: 0x060092D7 RID: 37591 RVA: 0x003A0310 File Offset: 0x0039E510
	public aqg()
	{
	}

	// Token: 0x060092D8 RID: 37592 RVA: 0x003A0318 File Offset: 0x0039E518
	public override double rk(cd1 A_0, efk A_1, efk A_2, double A_3, double A_4, bool A_5, AmmoType A_6, bool A_7, bool A_8)
	{
		return this.rl(A_0, A_1, A_2, A_8);
	}

	// Token: 0x060092D9 RID: 37593 RVA: 0x003A0328 File Offset: 0x0039E528
	public override double rl(cd1 A_0, efk A_1, efk A_2, bool A_3)
	{
		if (A_2 != null && A_2.b(d8o.e))
		{
			return this.a;
		}
		return 0.0;
	}

	// Token: 0x060092DA RID: 37594 RVA: 0x003A0350 File Offset: 0x0039E550
	public override string h0(cd1 A_0)
	{
		if (this.a >= 0.0)
		{
			return string.Format("Урон механическим целям увеличен на {0}%.", Convert.ToInt32(this.a * 100.0));
		}
		return string.Format("Урон механическим целям уменьшен на {0}%.", Convert.ToInt32(this.a * 100.0));
	}

	// Token: 0x060092DB RID: 37595 RVA: 0x003A03BC File Offset: 0x0039E5BC
	public override bns h1()
	{
		aqg aqg = new aqg();
		this.h2(aqg);
		return aqg;
	}

	// Token: 0x060092DC RID: 37596 RVA: 0x003A03D8 File Offset: 0x0039E5D8
	protected override void h2(bns A_0)
	{
		base.h2(A_0);
		((aqg)A_0).a = this.a;
	}

	// Token: 0x04003863 RID: 14435
	private new double a;
}
