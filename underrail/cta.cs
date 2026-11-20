using System;

// Token: 0x02000476 RID: 1142
public sealed class cta : adt
{
	// Token: 0x06001D87 RID: 7559 RVA: 0x000A3854 File Offset: 0x000A1A54
	public cta(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x000A3874 File Offset: 0x000A1A74
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		efk efk = this.Subject.a8().h.b.aa();
		if (!efk.Dead && efk.IsInControl)
		{
			amc amc = null;
			cqc cqc = base.Parent as cqc;
			if (cqc != null)
			{
				amc = cqc.adh();
			}
			if ((this.a == null || this.a.x() != dc4.b) && (this.b == null || A_0 >= this.b + this.c))
			{
				if (!cgh.a(amc, this.Subject))
				{
					return ej1.c;
				}
				this.b = new TimeSpan?(A_0);
				this.a = this.Subject.a8().h.b.b(amc);
			}
			if (amc != null)
			{
				awq.a(this.Subject.a8(), amc.a8(), false, false, true, true, false, false);
			}
			return ej1.a;
		}
		return ej1.c;
	}

	// Token: 0x06001D89 RID: 7561 RVA: 0x000A39CC File Offset: 0x000A1BCC
	public override float km(bool A_0)
	{
		return 0.75f;
	}

	// Token: 0x06001D8A RID: 7562 RVA: 0x000A39D4 File Offset: 0x000A1BD4
	public override bool acj(TimeSpan A_0, double A_1)
	{
		if (!base.Parent.acj(A_0, A_1))
		{
			return false;
		}
		if (base.h().aa().SpecialStates.g && (this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.a9, new bool?(false)).Value || this.Subject.ad().GetPrimitivePropertyValue<bool>(ddq.a9, new bool?(false)).Value))
		{
			cmb classPropertyValue = this.Subject.y6().GetClassPropertyValue<cmb>(cy1.h);
			if (classPropertyValue == null)
			{
				return false;
			}
			if (classPropertyValue.b((int)base.h().aa().Offense.u().TypedDefinition.ad()) > 2f)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x000A3AB0 File Offset: 0x000A1CB0
	public override void mc(TimeSpan A_0, double A_1)
	{
		this.a = null;
	}

	// Token: 0x06001D8C RID: 7564 RVA: 0x000A3ABC File Offset: 0x000A1CBC
	public override void ack()
	{
		if (this.a != null && this.a.x() == dc4.b)
		{
			this.a.j();
			this.a = null;
		}
	}

	// Token: 0x04001047 RID: 4167
	private btk a;

	// Token: 0x04001048 RID: 4168
	private new TimeSpan? b;

	// Token: 0x04001049 RID: 4169
	public new TimeSpan c = TimeSpan.FromMilliseconds(2000.0);
}
