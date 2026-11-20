using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001A66 RID: 6758
[eiz("MCTHVJSM")]
[Serializable]
public sealed class jr : bns, ISerializable
{
	// Token: 0x060092BD RID: 37565 RVA: 0x0039FFE0 File Offset: 0x0039E1E0
	private jr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MCTHVJSM:V");
	}

	// Token: 0x060092BE RID: 37566 RVA: 0x0039FFFC File Offset: 0x0039E1FC
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("MCTHVJSM:V", this.a);
	}

	// Token: 0x060092BF RID: 37567 RVA: 0x003A0018 File Offset: 0x0039E218
	public double a()
	{
		return this.a;
	}

	// Token: 0x060092C0 RID: 37568 RVA: 0x003A0020 File Offset: 0x0039E220
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060092C1 RID: 37569 RVA: 0x003A002C File Offset: 0x0039E22C
	public override bool hx()
	{
		return this.a < 0.0;
	}

	// Token: 0x060092C2 RID: 37570 RVA: 0x003A0040 File Offset: 0x0039E240
	public jr()
	{
	}

	// Token: 0x060092C3 RID: 37571 RVA: 0x003A004C File Offset: 0x0039E24C
	public override double hy(cd1 A_0, efk A_1, efk A_2)
	{
		if (A_2 != null && A_2.Vehicle != null && (A_2.Vehicle.y() == bws.b || A_2.Vehicle.y() == bws.a))
		{
			return this.a;
		}
		return 0.0;
	}

	// Token: 0x060092C4 RID: 37572 RVA: 0x003A009C File Offset: 0x0039E29C
	public override double hz(cd1 A_0, efk A_1, efk A_2, double A_3, double A_4, bool A_5, AmmoType A_6, bool A_7)
	{
		return this.hy(A_0, A_1, A_2);
	}

	// Token: 0x060092C5 RID: 37573 RVA: 0x003A00AC File Offset: 0x0039E2AC
	public override string h0(cd1 A_0)
	{
		if (this.a >= 0.0)
		{
			return string.Format("Шанс попадания по целям на гидроциклах увеличен на {0}%.", Convert.ToInt32(this.a * 100.0));
		}
		return string.Format("Шанс попадания по целям на гидроциклах уменьшен на {0}%.", Convert.ToInt32(this.a * 100.0));
	}

	// Token: 0x060092C6 RID: 37574 RVA: 0x003A0118 File Offset: 0x0039E318
	public override bns h1()
	{
		jr jr = new jr();
		this.h2(jr);
		return jr;
	}

	// Token: 0x060092C7 RID: 37575 RVA: 0x003A0134 File Offset: 0x0039E334
	protected override void h2(bns A_0)
	{
		base.h2(A_0);
		((jr)A_0).a = this.a;
	}

	// Token: 0x04003861 RID: 14433
	private new double a;
}
