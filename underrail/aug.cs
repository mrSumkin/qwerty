using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001967 RID: 6503
[eiz("RAOIDE")]
[Serializable]
public sealed class aug : wq, ISerializable
{
	// Token: 0x06008B23 RID: 35619 RVA: 0x0038E9F8 File Offset: 0x0038CBF8
	private aug(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("RAOIDE:R", typeof(ItemRepairCategory?)) as ItemRepairCategory?);
		this.b = A_0.GetDouble("RAOIDE:D");
	}

	// Token: 0x06008B24 RID: 35620 RVA: 0x0038EA38 File Offset: 0x0038CC38
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RAOIDE:R", this.a);
		info.AddValue("RAOIDE:D", this.b);
	}

	// Token: 0x06008B25 RID: 35621 RVA: 0x0038EA6C File Offset: 0x0038CC6C
	public ItemRepairCategory? b()
	{
		return this.a;
	}

	// Token: 0x06008B26 RID: 35622 RVA: 0x0038EA74 File Offset: 0x0038CC74
	public void a(ItemRepairCategory? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008B27 RID: 35623 RVA: 0x0038EA80 File Offset: 0x0038CC80
	public double a()
	{
		return this.b;
	}

	// Token: 0x06008B28 RID: 35624 RVA: 0x0038EA88 File Offset: 0x0038CC88
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008B29 RID: 35625 RVA: 0x0038EA94 File Offset: 0x0038CC94
	public aug()
	{
	}

	// Token: 0x06008B2A RID: 35626 RVA: 0x0038EA9C File Offset: 0x0038CC9C
	public aug(double A_0, ItemRepairCategory? A_1 = null)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x06008B2B RID: 35627 RVA: 0x0038EAB4 File Offset: 0x0038CCB4
	public override void dk(ll A_0, int A_1)
	{
		this.dl(A_0, A_1);
	}

	// Token: 0x06008B2C RID: 35628 RVA: 0x0038EAC0 File Offset: 0x0038CCC0
	public override void dl(ll A_0, int A_1)
	{
		if (A_0 != null && A_0.a() != null)
		{
			foreach (coh a_ in A_0.a().Gear.i())
			{
				this.a(a_);
			}
			foreach (coh a_2 in A_0.a().Bag.z2())
			{
				this.a(a_2);
			}
			A_0.a().bl();
		}
	}

	// Token: 0x06008B2D RID: 35629 RVA: 0x0038EB94 File Offset: 0x0038CD94
	public override wq dn()
	{
		aug aug = new aug();
		this.@do(aug);
		return aug;
	}

	// Token: 0x06008B2E RID: 35630 RVA: 0x0038EBB0 File Offset: 0x0038CDB0
	protected override void @do(wq A_0)
	{
		aug aug = (aug)A_0;
		aug.a = this.a;
		aug.b = this.b;
	}

	// Token: 0x06008B2F RID: 35631 RVA: 0x0038EBD4 File Offset: 0x0038CDD4
	private void a(coh A_0)
	{
		if (A_0 != null && A_0.Definition != null && !A_0.Definition.a9() && A_0.MaxDurability > 0 && (this.a == null || A_0.Definition.ay() == this.a.Value))
		{
			A_0.Durability = Math.Max(0.0, A_0.Durability - this.b);
		}
	}

	// Token: 0x0400378C RID: 14220
	private ItemRepairCategory? a;

	// Token: 0x0400378D RID: 14221
	private double b;
}
