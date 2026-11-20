using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000BA6 RID: 2982
[euj]
public class d2j
{
	// Token: 0x060043DA RID: 17370 RVA: 0x001AB2CC File Offset: 0x001A94CC
	[ayh("CCFRJPC")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				string classPropertyValue = bq.GetClassPropertyValue<string>("FirearmCode");
				if (!string.IsNullOrWhiteSpace(classPropertyValue))
				{
					int num = sg.c(classPropertyValue);
					bq.set_Item("RefurbishmentPrice", num);
				}
			}
		}
	}

	// Token: 0x060043DB RID: 17371 RVA: 0x001AB350 File Offset: 0x001A9550
	[ayh("CCFRJCIFP")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				string classPropertyValue = bq.GetClassPropertyValue<string>("FirearmCode");
				int value = bq.GetPrimitivePropertyValue<int>("RefurbishmentPrice", new int?(0)).Value;
				if (!string.IsNullOrWhiteSpace(classPropertyValue))
				{
					a7v.a(new aub(serviceOrThrow.aqu().v().a(classPropertyValue, 1, true)));
					a7v.a(new aub(serviceOrThrow.aqu().v().a("currency.sc", value, true)));
					this.a(serviceOrThrow, classPropertyValue);
					serviceOrThrow.aqu().r()["firearmRefurbishment_workingOnFirearm"] = true;
					serviceOrThrow.aqu().r()["firearmRefurbishment_firearmCode"] = classPropertyValue;
					string text = sg.a(serviceOrThrow.aqu().r().GetClassPropertyValue<string>("firearmRefurbishment_firearmCode"));
					if (!string.IsNullOrWhiteSpace(text) && sg.b(text))
					{
						serviceOrThrow.aqu().r()["firearmRefurbishment_delay"] = TimeSpan.FromMinutes(30.0);
					}
					else
					{
						serviceOrThrow.aqu().r()["firearmRefurbishment_delay"] = TimeSpan.FromMinutes(60.0);
					}
					serviceOrThrow.aqu().r()["firearmRefurbishment_startTime"] = serviceOrThrow.aqu().p();
					bq.set_Item("HasSchematics", sg.b(text));
				}
			}
		}
	}

	// Token: 0x060043DC RID: 17372 RVA: 0x001AB514 File Offset: 0x001A9714
	[ayh("CCFRJGFTP")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("firearmRefurbishment_firearmCode");
			if (!string.IsNullOrWhiteSpace(classPropertyValue))
			{
				string text = Path.Combine(bpo.GetServiceOrThrow<d67>().lf(), Path.Combine(d5x.ai, "Weapons"));
				if (Directory.Exists(text))
				{
					string[] files = Directory.GetFiles(text, "*.*", 1);
					for (int i = 0; i < files.Length; i++)
					{
						string str = files[i].Substring(text.Length + 1).Split(new string[]
						{
							"."
						}, StringSplitOptions.RemoveEmptyEntries)[0];
						coh coh = new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\" + str));
						if (coh != null && coh.Definition != null && !string.IsNullOrEmpty(coh.Definition.a5()) && coh.Definition.a5().Equals(classPropertyValue + "_rf"))
						{
							serviceOrThrow.aqu().v().Bag.z3(coh, true);
							a7v.a(new bou(coh));
							serviceOrThrow.aqu().r().RemoveProperty("firearmRefurbishment_firearmCode");
							return;
						}
					}
				}
			}
		}
	}

	// Token: 0x060043DD RID: 17373 RVA: 0x001AB680 File Offset: 0x001A9880
	[ayh("CCFRJCHCTF")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object obj;
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
		{
			bq8 bq = obj as bq8;
			if (bq != null)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("firearmRefurbishment_delay", null);
				TimeSpan? primitivePropertyValue2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("firearmRefurbishment_startTime", null);
				int num = 0;
				if (primitivePropertyValue != null && primitivePropertyValue2 != null)
				{
					if (primitivePropertyValue.Value + primitivePropertyValue2.Value - serviceOrThrow.aqu().p() <= TimeSpan.FromMinutes(10.0))
					{
						num = 2;
					}
					else if (primitivePropertyValue.Value + primitivePropertyValue2.Value - serviceOrThrow.aqu().p() <= TimeSpan.FromMinutes(20.0))
					{
						num = 1;
					}
				}
				bq.set_Item("HowCloseToFinishedLevel", num);
			}
		}
	}

	// Token: 0x060043DE RID: 17374 RVA: 0x001AB7C4 File Offset: 0x001A99C4
	private void a(cnk A_0, string A_1)
	{
		int a_;
		int num;
		List<string> list = sg.a(A_1, out a_, out num);
		if (list != null && Enumerable.Any<string>(list))
		{
			foreach (string text in list)
			{
				if (text.Contains("Frame") || text == "supersteel")
				{
					this.a(A_0, text, a_);
				}
				else
				{
					a7v.a(new aub(A_0.aqu().v().a(text, 1, true)));
				}
			}
		}
	}

	// Token: 0x060043DF RID: 17375 RVA: 0x001AB880 File Offset: 0x001A9A80
	private void a(cnk A_0, string A_1, int A_2)
	{
		List<fv> list = new List<fv>();
		foreach (coh coh in A_0.aqu().v().Bag.z2())
		{
			if (coh is fv)
			{
				fv fv = coh as fv;
				if (fv.Definition.a5() == A_1 && fv.QualityLevel >= A_2)
				{
					list.Add(fv);
				}
			}
		}
		if (Enumerable.Any<fv>(list))
		{
			Enumerable.OrderBy<fv, int>(list, new Func<fv, int>(d2j.a.a.a));
			a7v.a(new aub(list[0]));
			A_0.aqu().v().Bag.z5(list[0]);
		}
	}

	// Token: 0x02000BA7 RID: 2983
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060043E3 RID: 17379 RVA: 0x001AB9A0 File Offset: 0x001A9BA0
		internal int a(fv A_0)
		{
			return A_0.QualityLevel;
		}

		// Token: 0x04001C44 RID: 7236
		public static readonly d2j.a a = new d2j.a();

		// Token: 0x04001C45 RID: 7237
		public static Func<fv, int> b;
	}
}
