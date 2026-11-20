using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000876 RID: 2166
public sealed class ekl : el4
{
	// Token: 0x06003548 RID: 13640 RVA: 0x00146554 File Offset: 0x00144754
	protected override esj a3()
	{
		return new esj(6, 10);
	}

	// Token: 0x06003549 RID: 13641 RVA: 0x00146560 File Offset: 0x00144760
	public override string a4()
	{
		return "XPBL_WW_PROTECTORATESHIP_Y";
	}

	// Token: 0x0600354A RID: 13642 RVA: 0x00146568 File Offset: 0x00144768
	public override string a5()
	{
		return "Protectorate Ship Y";
	}

	// Token: 0x0600354B RID: 13643 RVA: 0x00146574 File Offset: 0x00144774
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_pz2_wipedOut", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROCompleted", new bool?(false)).Value);
	}

	// Token: 0x0600354C RID: 13644 RVA: 0x001465DC File Offset: 0x001447DC
	public override double ke()
	{
		return e3a.c;
	}

	// Token: 0x0600354D RID: 13645 RVA: 0x001465E4 File Offset: 0x001447E4
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600354E RID: 13646 RVA: 0x001465E8 File Offset: 0x001447E8
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x0600354F RID: 13647 RVA: 0x00146600 File Offset: 0x00144800
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x06003550 RID: 13648 RVA: 0x00146604 File Offset: 0x00144804
	public ekl() : base(new string[]
	{
		ega.bk,
		ega.bh
	})
	{
	}

	// Token: 0x06003551 RID: 13649 RVA: 0x00146624 File Offset: 0x00144824
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<string> list = d06.a(null, "Y");
		string text = list[cuo.a.Next(0, list.Count)];
		csd csd = A_1.g("randomEvents_boat");
		A_0.r()[A_1.y8() + "_ship_boatPath"] = text;
		A_0.r()[A_1.y8() + "_ship_boatWaypointName"] = csd.Name;
		A_1.g("Dump").Name = text + "Dump";
		erb.a(A_0, A_1, text, csd);
	}

	// Token: 0x06003552 RID: 13650 RVA: 0x001466CC File Offset: 0x001448CC
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
