using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.CustomLogic.Data;
using TimelapseVertigo.Rules;

// Token: 0x020008BF RID: 2239
public abstract class deq : el4
{
	// Token: 0x060037CF RID: 14287 RVA: 0x0014C838 File Offset: 0x0014AA38
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x060037D0 RID: 14288 RVA: 0x0014C844 File Offset: 0x0014AA44
	public override string a4()
	{
		return "CC_PH_BUR" + this.a.ToString();
	}

	// Token: 0x060037D1 RID: 14289 RVA: 0x0014C85C File Offset: 0x0014AA5C
	public override string a5()
	{
		return "Core City Player House Burglars " + this.a.ToString();
	}

	// Token: 0x060037D2 RID: 14290 RVA: 0x0014C878 File Offset: 0x0014AA78
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		Dictionary<PlayerHouseElement, string> dictionary = d39.a(A_0, null);
		string text;
		return base.e2(A_0, A_1, A_2) && dictionary.TryGetValue(PlayerHouseElement.MainFloorDebris, out text) && text != null && text == "cleared" && A_0.r().GetPrimitivePropertyValue<int>("loc_cc_ph_securityLevel", new int?(0)).Value < 2 && A_0.r().GetPrimitivePropertyValue<int>("loc_cc_ph_burglarsBrokeInto", new int?(0)).Value <= 4;
	}

	// Token: 0x060037D3 RID: 14291 RVA: 0x0014C90C File Offset: 0x0014AB0C
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060037D4 RID: 14292 RVA: 0x0014C910 File Offset: 0x0014AB10
	public override bool fl()
	{
		return true;
	}

	// Token: 0x060037D5 RID: 14293 RVA: 0x0014C918 File Offset: 0x0014AB18
	public override double ke()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("cc_ph_balconyDoor_unlocked", new bool?(false)).Value || serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("cc_ph_entranceDoor_unlocked", new bool?(false)).Value))
		{
			return base.TriggeringChance * 4.0;
		}
		return base.TriggeringChance;
	}

	// Token: 0x060037D6 RID: 14294 RVA: 0x0014C9A0 File Offset: 0x0014ABA0
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromSeconds(30.0));
	}

	// Token: 0x060037D7 RID: 14295 RVA: 0x0014C9B8 File Offset: 0x0014ABB8
	public deq(int A_0) : base(new string[]
	{
		ega.au
	})
	{
		this.a = A_0;
	}

	// Token: 0x060037D8 RID: 14296 RVA: 0x0014C9D8 File Offset: 0x0014ABD8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		A_0.r()["loc_cc_ph_hasOccupants"] = true;
		A_0.r()["loc_cc_ph_burglarsBrokeInto"] = A_0.r().GetPrimitivePropertyValue<int>("loc_cc_ph_burglarsBrokeInto", new int?(0)).Value + 1;
		A_0.r()["loc_cc_ph_hadTrespassers"] = true;
	}

	// Token: 0x060037D9 RID: 14297 RVA: 0x0014CA50 File Offset: 0x0014AC50
	protected c5x a(c5x A_0, c1a A_1)
	{
		bu6 service = bpo.GetService<bu6>();
		if (A_0 != null && A_0.h.b != null && service != null && service.aq2() >= GameDifficulty.Normal)
		{
			List<coh> list = new List<coh>();
			foreach (aud aud in Enumerable.ToList<aud>(A_1.Areas))
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.s.b != null && c5x.s.b is c7j)
					{
						c7j c7j = c5x.GetAspect<bim>() as c7j;
						if (Enumerable.Any<coh>(c7j.ItemContainer.z2()))
						{
							foreach (coh coh in c7j.ItemContainer.z2())
							{
								coh.CustomProperties["HomeContainerID"] = c5x.qe();
								coh.CustomProperties["HomeContainerAreaName"] = c5x.Area.y8();
								list.Add(coh);
							}
						}
					}
				}
			}
			if (Enumerable.Any<coh>(list))
			{
				list.Sort(new Comparison<coh>(deq.a.a.a));
				int num = 3;
				if (service.aq2() >= GameDifficulty.Hard)
				{
					num = 5;
				}
				foreach (coh coh2 in list)
				{
					if (num <= 0)
					{
						break;
					}
					if (coh2.Definition.bi() != a0.c && coh2.Definition.bc() != cr1.f && coh2.Definition.bc() != cr1.e && coh2.Weight < 50.0)
					{
						c5x c5x2 = new ar7(coh2.CustomProperties.GetPrimitivePropertyValue<Guid>("HomeContainerID", null).Value, A_1.n(coh2.CustomProperties.GetClassPropertyValue<string>("HomeContainerAreaName"))).ao() as c5x;
						if (c5x2 != null && c5x2.s.b != null && c5x2.s.b is c7j)
						{
							c7j c7j2 = c5x2.GetAspect<bim>() as c7j;
							if (!Enumerable.Any<cct>(Enumerable.OfType<cct>(c7j2.s())))
							{
								c7j2.s().Add(new cct("Эй, здесь чего-то не хватает!", true, null, bvl.d));
								List<cze> list2 = c7j2.s();
								bt8 bt = new bt8();
								bt.a(true);
								list2.Add(bt);
								c7j2.d(true);
							}
							coh2.CustomProperties.RemoveProperty("HomeContainerID");
							coh2.CustomProperties.RemoveProperty("HomeContainerAreaName");
							A_0.h.b.aa().Bag.z3(coh2, true);
							c7j2.ItemContainer.z5(coh2);
							num--;
						}
					}
				}
			}
		}
		return A_0;
	}

	// Token: 0x04001B8C RID: 7052
	private new int a;

	// Token: 0x020008C0 RID: 2240
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060037DC RID: 14300 RVA: 0x0014CE5C File Offset: 0x0014B05C
		internal int a(coh A_0, coh A_1)
		{
			return A_1.ItemValue.CompareTo(A_0.ItemValue);
		}

		// Token: 0x04001B8D RID: 7053
		public static readonly deq.a a = new deq.a();

		// Token: 0x04001B8E RID: 7054
		public static Comparison<coh> b;
	}
}
