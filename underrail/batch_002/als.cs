using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001608 RID: 5640
[eiz("IARA")]
[Serializable]
public class als : akg, ISerializable
{
	// Token: 0x06007C13 RID: 31763 RVA: 0x00341768 File Offset: 0x0033F968
	private als(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("IARA:D");
	}

	// Token: 0x06007C14 RID: 31764 RVA: 0x00341784 File Offset: 0x0033F984
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("IARA:D", this.a);
	}

	// Token: 0x06007C15 RID: 31765 RVA: 0x00341798 File Offset: 0x0033F998
	public double a()
	{
		return this.a;
	}

	// Token: 0x06007C16 RID: 31766 RVA: 0x003417A0 File Offset: 0x0033F9A0
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06007C17 RID: 31767 RVA: 0x003417AC File Offset: 0x0033F9AC
	public als(amc A_0, amc A_1, cwt A_2, double A_3, enp A_4 = null) : base(A_0, A_1, A_2, A_4, false)
	{
		this.a = A_3;
	}

	// Token: 0x06007C18 RID: 31768 RVA: 0x003417C8 File Offset: 0x0033F9C8
	protected override cwt p7()
	{
		cwt cwt = base.d().a();
		if (base.m() != null)
		{
			int a_;
			if (base.m().aa().Defense.q().zo() < 2f)
			{
				a_ = 0;
			}
			else
			{
				a_ = Math.Min((int)((double)base.m().aa().Defense.q().zo() * this.a), (int)(base.m().aa().Defense.q().zo() - 1f));
			}
			cwt.f.Add(new csk(DamageType.Mechanical, a_));
		}
		return cwt;
	}

	// Token: 0x04003149 RID: 12617
	private new double a;
}
