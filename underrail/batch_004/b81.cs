using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Vehicles;

// Token: 0x02001954 RID: 6484
[elw(typeof(agt))]
[eiz("VPI")]
[Serializable]
public abstract class b81 : dj3, ISerializable
{
	// Token: 0x06008A60 RID: 35424 RVA: 0x0038CD14 File Offset: 0x0038AF14
	protected b81(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("VPI:S");
		if (ell.a() >= 381)
		{
			this.b = A_0.GetBoolean("VPI:B");
		}
		if (ell.a() >= 386)
		{
			di7.ReadList<aia>("VPI:C", ref this.c, A_0);
			return;
		}
		this.c = new List<aia>();
	}

	// Token: 0x06008A61 RID: 35425 RVA: 0x0038CD94 File Offset: 0x0038AF94
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VPI:S", this.a);
		info.AddValue("VPI:B", this.b);
		di7.WriteList<aia>("VPI:C", this.c, info);
	}

	// Token: 0x06008A62 RID: 35426 RVA: 0x0038CDDC File Offset: 0x0038AFDC
	public override string tv()
	{
		return "Часть транспорта";
	}

	// Token: 0x06008A63 RID: 35427
	public abstract VehiclePartType qp();

	// Token: 0x06008A64 RID: 35428 RVA: 0x0038CDE4 File Offset: 0x0038AFE4
	public int l()
	{
		return this.a;
	}

	// Token: 0x06008A65 RID: 35429 RVA: 0x0038CDEC File Offset: 0x0038AFEC
	public void b(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008A66 RID: 35430 RVA: 0x0038CDF8 File Offset: 0x0038AFF8
	public bool j()
	{
		return this.b;
	}

	// Token: 0x06008A67 RID: 35431 RVA: 0x0038CE00 File Offset: 0x0038B000
	public new void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008A68 RID: 35432 RVA: 0x0038CE0C File Offset: 0x0038B00C
	public List<aia> k()
	{
		return this.c;
	}

	// Token: 0x06008A69 RID: 35433 RVA: 0x0038CE14 File Offset: 0x0038B014
	public new void a(List<aia> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008A6A RID: 35434 RVA: 0x0038CE20 File Offset: 0x0038B020
	public b81()
	{
	}

	// Token: 0x06008A6B RID: 35435 RVA: 0x0038CE34 File Offset: 0x0038B034
	public virtual void qq(bcx A_0, agt A_1)
	{
		A_0.ai().AddRange(this.c);
	}

	// Token: 0x06008A6C RID: 35436 RVA: 0x0038CE48 File Offset: 0x0038B048
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		b81 b = (b81)A_0;
		b.a = this.a;
		b.b = this.b;
		foreach (aia aia in this.c)
		{
			b.c.Add(aia.b());
		}
	}

	// Token: 0x04003707 RID: 14087
	private new int a;

	// Token: 0x04003708 RID: 14088
	private bool b;

	// Token: 0x04003709 RID: 14089
	private List<aia> c = new List<aia>();
}
