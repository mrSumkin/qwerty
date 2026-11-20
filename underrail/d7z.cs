using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000877 RID: 2167
public sealed class d7z : el4
{
	// Token: 0x06003553 RID: 13651 RVA: 0x00146780 File Offset: 0x00144980
	protected override esj a3()
	{
		return new esj(6, 10);
	}

	// Token: 0x06003554 RID: 13652 RVA: 0x0014678C File Offset: 0x0014498C
	public override string a4()
	{
		return "XPBL_WW_MERCHANTSHIP_Y";
	}

	// Token: 0x06003555 RID: 13653 RVA: 0x00146794 File Offset: 0x00144994
	public override string a5()
	{
		return "Merchant Ship Y";
	}

	// Token: 0x06003556 RID: 13654 RVA: 0x0014679C File Offset: 0x0014499C
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x06003557 RID: 13655 RVA: 0x001467A4 File Offset: 0x001449A4
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003558 RID: 13656 RVA: 0x001467A8 File Offset: 0x001449A8
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x06003559 RID: 13657 RVA: 0x001467C0 File Offset: 0x001449C0
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x0600355A RID: 13658 RVA: 0x001467C4 File Offset: 0x001449C4
	public d7z() : base(new string[]
	{
		ega.bn,
		ega.bm,
		ega.bk,
		ega.bh,
		ega.bs
	})
	{
	}

	// Token: 0x0600355B RID: 13659 RVA: 0x00146800 File Offset: 0x00144A00
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<string> list = d06.c(null, "Y");
		string fi = asp.fi;
		string text = list[cuo.a.Next(0, list.Count)];
		string value = "randomEvents_" + text;
		csd csd = A_1.g("randomEvents_boat");
		A_0.r()[A_1.y8() + "_ship_boatPath"] = text;
		A_0.r()[A_1.y8() + "_ship_boatWaypointName"] = csd.Name;
		A_1.g("Dump").Name = text + "Dump";
		erb.a(A_0, A_1, text, csd);
		d06.a(A_1, fi);
		string a_ = d06.a();
		bool a_2 = cuo.a.Next(0, 101) < 20;
		foreach (csd csd2 in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			c5x c5x = null;
			if (csd2.Name.Contains(value))
			{
				c5x = d06.a(csd2, fi, 13, a_, false, a_2);
			}
			if (c5x != null)
			{
				base.iy(c5x);
			}
		}
	}

	// Token: 0x0600355C RID: 13660 RVA: 0x00146960 File Offset: 0x00144B60
	public override bool kg(cyt A_0, c1a A_1)
	{
		if (base.kg(A_0, A_1))
		{
			string classPropertyValue = A_0.r().GetClassPropertyValue<string>(A_1.y8() + "_ship_boatPath");
			if (classPropertyValue != null)
			{
				erb.a(classPropertyValue, A_1.g(A_0.r().GetClassPropertyValue<string>(A_1.y8() + "_ship_boatWaypointName")));
				Enumerable.ToList<csd>(A_1.Waypoints).Remove(A_1.g(classPropertyValue + "Dump"));
				A_0.r().RemoveProperty(classPropertyValue);
				A_0.r().RemoveProperty(A_1.y8() + "_ship_boatWaypointName");
			}
			return true;
		}
		return false;
	}
}
