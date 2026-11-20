using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Locale;

// Token: 0x0200125E RID: 4702
[a(typeof(arn))]
[eiz("C38")]
[Serializable]
public abstract class arn : Aspect<c5x>, ISerializable
{
	// Token: 0x060065B4 RID: 26036 RVA: 0x002B4C74 File Offset: 0x002B2E74
	protected arn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("C38:O", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.b = A_0.GetInt32("C38:C");
		if (ell.a() >= 185)
		{
			this.c = (A_0.GetValue("C38:I", typeof(coh)) as coh);
		}
	}

	// Token: 0x060065B5 RID: 26037 RVA: 0x002B4CEC File Offset: 0x002B2EEC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("C38:O", this.a);
		info.AddValue("C38:C", this.b);
		info.AddValue("C38:I", this.c);
	}

	// Token: 0x060065B6 RID: 26038 RVA: 0x002B4D34 File Offset: 0x002B2F34
	public amc b()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x060065B7 RID: 26039 RVA: 0x002B4D50 File Offset: 0x002B2F50
	public int d()
	{
		return this.b;
	}

	// Token: 0x060065B8 RID: 26040 RVA: 0x002B4D58 File Offset: 0x002B2F58
	public coh a()
	{
		return this.c;
	}

	// Token: 0x060065B9 RID: 26041 RVA: 0x002B4D60 File Offset: 0x002B2F60
	protected arn(c5x A_0, EntityAspectReference<amc, amc> A_1, int A_2, coh A_3) : base(A_0)
	{
		this.a = A_1;
		this.b = A_2;
		if (A_3 != null)
		{
			this.c = A_3.fy();
		}
	}

	// Token: 0x060065BA RID: 26042 RVA: 0x002B4D90 File Offset: 0x002B2F90
	public bool b(c5x A_0)
	{
		this.ed(A_0, this.b);
		int num = this.b - 1;
		this.b = num;
		if (num <= 0)
		{
			return true;
		}
		if (base.a8().o.b != null)
		{
			base.a8().o.b.b = new Point(base.a8().o.b.b.X, this.b - 1);
		}
		return false;
	}

	// Token: 0x060065BB RID: 26043 RVA: 0x002B4E18 File Offset: 0x002B3018
	protected virtual void ed(c5x A_0, int A_1)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			if (A_0.h.b.aa().Defense.q().zo() >= 2f)
			{
				csk item = euf.a(c18.f(), 1.0);
				if (item.Amount >= (int)A_0.h.b.aa().Defense.q().zo())
				{
					item = new csk(item.DamageType, (int)A_0.h.b.aa().Defense.q().zo() - 1);
				}
				cwt cwt = new cwt();
				cwt.f.Add(item);
				if (this.b() != null)
				{
					cwt.i = new ap9(this.b().aa());
				}
				cwt.b = true;
				cwt.w = true;
				cwt.l = true;
				cwt.p = true;
				cwt.j = new ap9(A_0.h.b.aa());
				cwt.k = "caltrops";
				cwt.ad["IsCaltrop"] = true;
				A_0.h.b.aa().Defense.a(cwt);
			}
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				d4n d4n = service.ahu(A_0.h.b.aa());
				if (d4n != null && d4n == service.ahe())
				{
					d4n.b(c18.b1, true);
					vr a_ = new vr(new ap9(A_0.h.b.aa()), null, "{0} наступает на колючки и теряет " + c18.b1.ToString() + " очков передвижения.", new Color?(adi.j), null);
					bey.a(a_, A_0.h.b.aa(), A_0.h.b);
					a7v.a(a_);
					bmj.a(A_0, new ccq(ScrollingCombatTextOptions.Damage, string.Format("-{0} очков передвижения (колючки)", c18.b1), adi.j, null, false));
				}
			}
			if (this.b() != null && this.b() != A_0.h.b)
			{
				this.a(A_0);
			}
		}
	}

	// Token: 0x060065BC RID: 26044 RVA: 0x002B5080 File Offset: 0x002B3280
	private void a(c5x A_0)
	{
		if (this.b() != null && A_0 != null && A_0.h.b != null)
		{
			ZoneControlLevel zoneControlLevel;
			if (!A_0.h.b.aa().Passive)
			{
				zoneControlLevel = eir.a(A_0.Zone, A_0.h.b.aa().FactionId);
			}
			else
			{
				zoneControlLevel = ZoneControlLevel.Uncontrolled;
			}
			if (zoneControlLevel != ZoneControlLevel.Uncontrolled)
			{
				awq.a(this.b(), A_0.h.b, false, false, null, true, false, false, false);
			}
		}
	}

	// Token: 0x04002A50 RID: 10832
	private EntityAspectReference<amc, amc> a;

	// Token: 0x04002A51 RID: 10833
	private int b;

	// Token: 0x04002A52 RID: 10834
	private coh c;
}
