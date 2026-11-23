using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x02000A24 RID: 2596
[eiz("XPBLSR")]
[Serializable]
public sealed class byv : bdw, ISerializable
{
	// Token: 0x06003DB4 RID: 15796 RVA: 0x00171EB0 File Offset: 0x001700B0
	private byv(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DB5 RID: 15797 RVA: 0x00171EB8 File Offset: 0x001700B8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DB6 RID: 15798 RVA: 0x00171EBC File Offset: 0x001700BC
	public byv()
	{
	}

	// Token: 0x06003DB7 RID: 15799 RVA: 0x00171EC4 File Offset: 0x001700C4
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("xpbl_cc-dock2");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_cc-dock2_l" + 2.ToString()) + ".uzl");
				aud.Zone.a(a_, 1, null);
				serviceOrThrow.aqu().r()["loc_xpbl_cc-dock2_shopOpen"] = true;
				c5x c5x = new ar7(new Guid("18d20510-92d2-44e2-9ee5-67855a02c06a"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("b7dee55e-00f0-43a0-bd27-38e6f2a7d6ec"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("50854fcb-4c6a-4dd9-8259-dd170b19dc5d"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("63c78795-c865-4dd1-adb5-a23ffdd27182"), aud).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("116a445f-16b2-4f14-961a-a4840ffe9f6e"), aud).ao() as c5x;
				if (c5x != null)
				{
					cnb cnb = c5x.GetAspect<bim>() as cnb;
					if (cnb != null)
					{
						if (cnb.q())
						{
							cnb.d(false);
							alv aspect = c5x.GetAspect<alv>();
							if (aspect != null)
							{
								aspect.a[0].b.X = 5;
								aspect.a[0].b.Y = 1;
								aspect.a[1].b.X = 5;
								aspect.a[1].b.Y = 3;
							}
						}
						cnb.g(true);
					}
					d2b aspect2 = c5x.GetAspect<d2b>();
					if (aspect2 != null && aspect2.n())
					{
						aspect2.e(false);
					}
					else
					{
						serviceOrThrow.aqu().r()["loc_xpbl_cc-dock2_brokenInto"] = true;
					}
					c3g aspect3 = c5x.GetAspect<c3g>();
					if (aspect3 != null)
					{
						aspect3.d().Clear();
					}
				}
				if (c5x2 != null)
				{
					cnb cnb2 = c5x2.GetAspect<bim>() as cnb;
					if (cnb2 != null)
					{
						if (cnb2.q())
						{
							cnb2.d(false);
							alv aspect4 = c5x2.GetAspect<alv>();
							if (aspect4 != null)
							{
								aspect4.a[0].b.X = 2;
								aspect4.a[0].b.Y = 1;
								aspect4.a[1].b.X = 2;
								aspect4.a[1].b.Y = 3;
							}
						}
						cnb2.g(true);
					}
					d2b aspect5 = c5x2.GetAspect<d2b>();
					if (aspect5 != null && aspect5.n())
					{
						aspect5.e(false);
					}
					else
					{
						serviceOrThrow.aqu().r()["loc_xpbl_cc-dock2_brokenInto"] = true;
					}
					c3g aspect6 = c5x2.GetAspect<c3g>();
					if (aspect6 != null)
					{
						aspect6.d().Clear();
					}
				}
				if (c5x3 != null)
				{
					cnb cnb3 = c5x3.GetAspect<bim>() as cnb;
					if (cnb3 != null && cnb3.q())
					{
						cnb3.d(false);
					}
					d2b aspect7 = c5x3.GetAspect<d2b>();
					if (aspect7 != null && !aspect7.n())
					{
						serviceOrThrow.aqu().r()["loc_xpbl_cc-dock2_brokenInto"] = true;
					}
					aspect7.e(false);
					c3g aspect8 = c5x3.GetAspect<c3g>();
					if (aspect8 != null)
					{
						aspect8.d().Clear();
					}
				}
				if (c5x4 != null)
				{
					cnb cnb4 = c5x4.GetAspect<bim>() as cnb;
					if (cnb4 != null && cnb4.q())
					{
						cnb4.d(false);
					}
					d2b aspect9 = c5x4.GetAspect<d2b>();
					if (aspect9 != null)
					{
						if (!aspect9.n())
						{
							serviceOrThrow.aqu().r()["loc_xpbl_cc-dock2_attemptedBreakIn"] = true;
						}
						aspect9.e(false);
					}
					c3g aspect10 = c5x4.GetAspect<c3g>();
					if (aspect10 != null)
					{
						aspect10.d().Clear();
					}
				}
				if (c5x5 != null)
				{
					d2b aspect11 = c5x5.GetAspect<d2b>();
					if (aspect11 != null)
					{
						if (!aspect11.n())
						{
							serviceOrThrow.aqu().r()["loc_xpbl_cc-dock2_attemptedBreakIn"] = true;
						}
						aspect11.e(false);
					}
				}
				c5x c5x6 = new ar7(new Guid("70a502cc-7944-45e6-bbf1-3dcfe2df0e0a"), aud).ao() as c5x;
				if (c5x6 != null)
				{
					dbm dbm = c5x6.GetAspect<bim>() as dbm;
					if (dbm != null && dbm.m())
					{
						dbm.l();
						serviceOrThrow.aqu().r()["loc_xpbl_cc-dock2_brokenInto"] = true;
					}
				}
				c5x c5x7 = new ar7(new Guid("5902d2eb-3562-4e2b-a7d8-40a3c1ac5d29"), aud).ao() as c5x;
				if (c5x7 != null)
				{
					c7j c7j = c5x7.GetAspect<bim>() as c7j;
					if (c7j != null)
					{
						List<d5o> list = c7j.ItemContainer.z2().a("currency.sc", 418);
						if (Enumerable.Sum<d5o>(list, new Func<d5o, int>(byv.a.a.c)) == 418)
						{
							serviceOrThrow.aqu().r()["npc_cc_ray_moneyStolen"] = "None";
						}
						else
						{
							if (Enumerable.Sum<d5o>(list, new Func<d5o, int>(byv.a.a.b)) > 200)
							{
								serviceOrThrow.aqu().r()["npc_cc_ray_moneyStolen"] = "половину от суммы";
							}
							else if (Enumerable.Sum<d5o>(list, new Func<d5o, int>(byv.a.a.a)) > 0)
							{
								serviceOrThrow.aqu().r()["npc_cc_ray_moneyStolen"] = "почти все деньги";
							}
							else
							{
								serviceOrThrow.aqu().r()["npc_cc_ray_moneyStolen"] = "все деньги";
							}
							serviceOrThrow.aqu().r()["loc_xpbl_cc-dock2_brokenInto"] = true;
						}
					}
				}
				List<c5x> list2 = new List<c5x>();
				list2.Add(new ar7(new Guid("4e95cab2-af58-4eb5-97ad-9e1e78c970d3"), aud).ao() as c5x);
				list2.Add(new ar7(new Guid("7cf7be49-1b4e-472b-b655-024a906e16a2"), aud).ao() as c5x);
				list2.Add(new ar7(new Guid("0b1045c4-ec5f-46d1-a270-b52fc11f2d81"), aud).ao() as c5x);
				list2.Add(new ar7(new Guid("926a3290-ba07-4ebf-aaa6-bbf36c8cb039"), aud).ao() as c5x);
				list2.Add(new ar7(new Guid("141dfeb3-741d-40cf-9383-0e93b9ace629"), aud).ao() as c5x);
				list2.Add(new ar7(new Guid("f5e7da90-af4a-4609-88b9-b0bbbf1d0a7f"), aud).ao() as c5x);
				list2.Add(new ar7(new Guid("8a9ab8ee-937a-43a0-b726-cf15448b66c5"), aud).ao() as c5x);
				list2.Add(new ar7(new Guid("6257c129-2db0-43db-911b-aee13e83b0d7"), aud).ao() as c5x);
				List<c5x> list3 = new List<c5x>();
				list3.Add(new ar7(new Guid("d5379081-0dfd-4c06-bc30-f06a36ed06ff"), aud).ao() as c5x);
				list3.Add(new ar7(new Guid("817d1a52-ec5d-4cf3-bebe-e78cd6d48884"), aud).ao() as c5x);
				list3.Add(new ar7(new Guid("e4c7d870-a34a-4f79-8b32-a4db8fdfacb0"), aud).ao() as c5x);
				list3.Add(new ar7(new Guid("db41787b-1871-46d4-9775-661cfec065dd"), aud).ao() as c5x);
				list3.Add(new ar7(new Guid("492aad51-258c-4fc0-a715-d914bbae85b1"), aud).ao() as c5x);
				list3.Add(new ar7(new Guid("75cfa418-1a6c-40b2-80a9-cb9f5fdfbbf4"), aud).ao() as c5x);
				list3.Add(new ar7(new Guid("39fae17b-ac04-409d-b549-f88dd1aab129"), aud).ao() as c5x);
				list3.Add(new ar7(new Guid("73737b04-6ae3-467a-9ccd-3209bcc24df5"), aud).ao() as c5x);
				list3.Add(new ar7(new Guid("025bb772-849e-4921-9dee-69cd602051f8"), aud).ao() as c5x);
				list3.Add(new ar7(new Guid("a4c6bd8d-9b28-4262-abe6-a7018e6e0ffe"), aud).ao() as c5x);
				list3.Add(new ar7(new Guid("f910e1a0-1562-41e9-b6c8-7be20a53a749"), aud).ao() as c5x);
				list3.Add(new ar7(new Guid("7df51d15-0a2a-4e5a-a7c7-09a19f036956"), aud).ao() as c5x);
				foreach (c5x c5x8 in list2)
				{
					if (c5x8 != null)
					{
						c7j c7j2 = c5x8.GetAspect<bim>() as c7j;
						if (c7j2 != null && c7j2.ItemContainer.z2().Count == 0)
						{
							serviceOrThrow.aqu().r()["npc_cc_ray_itemsStolen"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_cc_ray_itemsStolen_number", new int?(0)).Value + 1;
							serviceOrThrow.aqu().r()["loc_xpbl_cc-dock2_brokenInto"] = true;
						}
					}
				}
				using (List<c5x>.Enumerator enumerator = list3.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == null)
						{
							serviceOrThrow.aqu().r()["npc_cc_ray_jetsStolen_number"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_cc_ray_jetsStolen_number", new int?(0)).Value + 1;
							serviceOrThrow.aqu().r()["loc_xpbl_cc-dock2_brokenInto"] = true;
						}
					}
				}
				c5x c5x9 = new ar7(new Guid("1437470b-8b0a-4513-9f00-7afaddba7390"), aud).ao() as c5x;
				if (c5x5 != null)
				{
					c5x5.an();
					c5x5.w();
				}
				if (c5x9 != null)
				{
					c5x9.an();
					c5x9.w();
				}
				c5x c5x10 = new ar7(new Guid("a7207edc-0c69-41d7-b3a3-3f6f62fa00f4"), aud).ao() as c5x;
				bsl bsl = c5x10.GetAspect<bim>() as bsl;
				if (bsl != null)
				{
					bsl.t().Add(HorizontalDirection.Northeast);
					if (!bsl.b())
					{
						bsl.aal(serviceOrThrow.aqu().v().b() as c5x, true, true);
						axh aspect12 = c5x10.GetAspect<axh>();
						if (aspect12 != null)
						{
							aspect12.a(serviceOrThrow.aqu().v().b() as c5x);
						}
					}
				}
			}
		}
	}

	// Token: 0x02000A25 RID: 2597
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003DBA RID: 15802 RVA: 0x00172A20 File Offset: 0x00170C20
		internal int c(d5o A_0)
		{
			return A_0.StackPortion;
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00172A28 File Offset: 0x00170C28
		internal int b(d5o A_0)
		{
			return A_0.StackPortion;
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x00172A30 File Offset: 0x00170C30
		internal int a(d5o A_0)
		{
			return A_0.StackPortion;
		}

		// Token: 0x04001BA3 RID: 7075
		public static readonly byv.a a = new byv.a();

		// Token: 0x04001BA4 RID: 7076
		public static Func<d5o, int> b;

		// Token: 0x04001BA5 RID: 7077
		public static Func<d5o, int> c;

		// Token: 0x04001BA6 RID: 7078
		public static Func<d5o, int> d;
	}
}
