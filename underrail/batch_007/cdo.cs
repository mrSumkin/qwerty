using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001215 RID: 4629
[eiz("ZTT")]
[Serializable]
public sealed class cdo : ya, ISerializable
{
	// Token: 0x0600639E RID: 25502 RVA: 0x002AEEC4 File Offset: 0x002AD0C4
	private cdo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (c2w)A_0.GetValue("ZTT:D", typeof(c2w));
		}
		else if (base.GetType() == typeof(cdo))
		{
			this.a = (c2w)A_0.GetValue("_Destination", typeof(c2w));
		}
		else
		{
			this.a = (c2w)A_0.GetValue("ZoneTransitionTrigger+_Destination", typeof(c2w));
		}
		if (ell.a() >= 334)
		{
			this.b = (A_0.GetValue("ZTT:C", typeof(dth)) as dth);
		}
		if (ell.a() >= 339)
		{
			this.c = A_0.GetBoolean("ZTT:O");
		}
	}

	// Token: 0x0600639F RID: 25503 RVA: 0x002AEFC4 File Offset: 0x002AD1C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ZTT:D", this.a);
		info.AddValue("ZTT:C", this.b);
		info.AddValue("ZTT:O", this.c);
	}

	// Token: 0x060063A0 RID: 25504 RVA: 0x002AF00C File Offset: 0x002AD20C
	public c2w b()
	{
		return this.a;
	}

	// Token: 0x060063A1 RID: 25505 RVA: 0x002AF014 File Offset: 0x002AD214
	public void a(c2w A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060063A2 RID: 25506 RVA: 0x002AF020 File Offset: 0x002AD220
	public dth c()
	{
		return this.b;
	}

	// Token: 0x060063A3 RID: 25507 RVA: 0x002AF028 File Offset: 0x002AD228
	public void a(dth A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060063A4 RID: 25508 RVA: 0x002AF034 File Offset: 0x002AD234
	public bool a()
	{
		return this.c;
	}

	// Token: 0x060063A5 RID: 25509 RVA: 0x002AF03C File Offset: 0x002AD23C
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060063A6 RID: 25510 RVA: 0x002AF048 File Offset: 0x002AD248
	public cdo()
	{
	}

	// Token: 0x060063A7 RID: 25511 RVA: 0x002AF060 File Offset: 0x002AD260
	protected override void ac2(b0b A_0)
	{
		if (dz6.e() && A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null && aspect.aa() is e3q && bpo.GetServiceOrThrow<cnk>().aqu() != null)
			{
				int zoneTransitionApCost = euf.b().ZoneTransitionApCost;
				if (zoneTransitionApCost > 0)
				{
					d4n d4n = dz6.b(aspect.aa());
					if (d4n != null)
					{
						if (d4n.c < (double)zoneTransitionApCost)
						{
							bmj.a(A_0, new cwl());
							return;
						}
						d4n.a(zoneTransitionApCost, true);
					}
				}
			}
		}
		Point? a_ = null;
		if (this.c && A_0 != null)
		{
			Point a_2 = A_0.aj().a();
			a_ = new Point?(d05.a(a_2, base.Location, true));
		}
		a0l.a(A_0 as c5x, this.a, 0, a_);
	}

	// Token: 0x040029F0 RID: 10736
	private c2w a = new c2w();

	// Token: 0x040029F1 RID: 10737
	private dth b;

	// Token: 0x040029F2 RID: 10738
	private bool c;
}
