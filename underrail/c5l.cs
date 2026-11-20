using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000878 RID: 2168
public sealed class c5l : el4
{
	// Token: 0x0600355D RID: 13661 RVA: 0x00146A14 File Offset: 0x00144C14
	protected override esj a3()
	{
		return new esj(10, 6);
	}

	// Token: 0x0600355E RID: 13662 RVA: 0x00146A20 File Offset: 0x00144C20
	public override string a4()
	{
		return "XPBL_WW_MERCHANTSHIP_X";
	}

	// Token: 0x0600355F RID: 13663 RVA: 0x00146A28 File Offset: 0x00144C28
	public override string a5()
	{
		return "Merchant Ship X";
	}

	// Token: 0x06003560 RID: 13664 RVA: 0x00146A30 File Offset: 0x00144C30
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x06003561 RID: 13665 RVA: 0x00146A38 File Offset: 0x00144C38
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003562 RID: 13666 RVA: 0x00146A3C File Offset: 0x00144C3C
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x06003563 RID: 13667 RVA: 0x00146A54 File Offset: 0x00144C54
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x06003564 RID: 13668 RVA: 0x00146A58 File Offset: 0x00144C58
	public c5l() : base(new string[]
	{
		ega.bl,
		ega.bk,
		ega.bs
	})
	{
	}

	// Token: 0x06003565 RID: 13669 RVA: 0x00146A84 File Offset: 0x00144C84
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<string> list = d06.c(null, "X");
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

	// Token: 0x06003566 RID: 13670 RVA: 0x00146BE4 File Offset: 0x00144DE4
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
