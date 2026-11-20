using System;
using System.Runtime.Serialization;

// Token: 0x02001A67 RID: 6759
[eiz("IESM")]
[Serializable]
public sealed class cnc : bns, ISerializable
{
	// Token: 0x060092C8 RID: 37576 RVA: 0x003A0150 File Offset: 0x0039E350
	private cnc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("IESM:V");
	}

	// Token: 0x060092C9 RID: 37577 RVA: 0x003A016C File Offset: 0x0039E36C
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("IESM:V", this.a);
	}

	// Token: 0x060092CA RID: 37578 RVA: 0x003A0188 File Offset: 0x0039E388
	public double a()
	{
		return this.a;
	}

	// Token: 0x060092CB RID: 37579 RVA: 0x003A0190 File Offset: 0x0039E390
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060092CC RID: 37580 RVA: 0x003A019C File Offset: 0x0039E39C
	public override bool hx()
	{
		return this.a < 0.0;
	}

	// Token: 0x060092CD RID: 37581 RVA: 0x003A01B0 File Offset: 0x0039E3B0
	public cnc()
	{
	}

	// Token: 0x060092CE RID: 37582 RVA: 0x003A01BC File Offset: 0x0039E3BC
	public override double af6(efk A_0, bool A_1)
	{
		if (A_0 != null && A_0.Vehicle != null && (A_0.Vehicle.y() == bws.b || A_0.Vehicle.y() == bws.a))
		{
			return this.a;
		}
		return 0.0;
	}

	// Token: 0x060092CF RID: 37583 RVA: 0x003A020C File Offset: 0x0039E40C
	public override string h0(cd1 A_0)
	{
		if (this.a >= 0.0)
		{
			return string.Format("Эффективная устойчивость увеличена на {0}% при атаках с гидроцикла.", Convert.ToInt32(this.a * 100.0));
		}
		return string.Format("Эффективная устойчивость уменьшена на {0}% при атаках с гидроцикла.", Convert.ToInt32(this.a * 100.0));
	}

	// Token: 0x060092D0 RID: 37584 RVA: 0x003A0278 File Offset: 0x0039E478
	public override bns h1()
	{
		cnc cnc = new cnc();
		this.h2(cnc);
		return cnc;
	}

	// Token: 0x060092D1 RID: 37585 RVA: 0x003A0294 File Offset: 0x0039E494
	protected override void h2(bns A_0)
	{
		base.h2(A_0);
		((cnc)A_0).a = this.a;
	}

	// Token: 0x04003862 RID: 14434
	private new double a;
}
