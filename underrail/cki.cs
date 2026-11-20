using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000A6A RID: 2666
[eiz("TCHHTHBI")]
[Serializable]
public sealed class cki : cze, ISerializable
{
	// Token: 0x06003EF3 RID: 16115 RVA: 0x0017CD9C File Offset: 0x0017AF9C
	private cki(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003EF4 RID: 16116 RVA: 0x0017CDA8 File Offset: 0x0017AFA8
	public cki()
	{
	}

	// Token: 0x06003EF5 RID: 16117 RVA: 0x0017CDB4 File Offset: 0x0017AFB4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null)
		{
			cky cky = (serviceOrThrow.aqu().ac() as bv9).abu(asp.a, asp.es);
			if (cky != null && cky.a == h.a && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_InterviewCompleted", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_hostiityCleanupDone", new bool?(false)).Value)
			{
				serviceOrThrow.aqz().atd("tch_getInterviewd", true);
				ya ya = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(serviceOrThrow.aqu().v().b().Zone.n("tch-entry").Triggers, new Func<ya, bool>(cki.a.a.a)));
				if (ya != null)
				{
					ya.o();
				}
				serviceOrThrow.aqu().r()["loc_tch_hostiityCleanupDone"] = true;
			}
		}
	}

	// Token: 0x02000A6B RID: 2667
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06003EF8 RID: 16120 RVA: 0x0017CF04 File Offset: 0x0017B104
		internal bool a(ya A_0)
		{
			return A_0.Name == "StartInterview";
		}

		// Token: 0x04001BCE RID: 7118
		public static readonly cki.a a = new cki.a();

		// Token: 0x04001BCF RID: 7119
		public static Func<ya, bool> b;
	}
}
