using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003C1 RID: 961
[fe("jye_deputy")]
public sealed class a7y : b5g
{
	// Token: 0x06001A1D RID: 6685 RVA: 0x0008C75C File Offset: 0x0008A95C
	public a7y(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new b64("Searching", new Func<TimeSpan, double, bool>(a7y.a.a.a), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(a7y.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001A1E RID: 6686 RVA: 0x0008C7EC File Offset: 0x0008A9EC
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string a = null;
			bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay);
			if (classPropertyValue != null)
			{
				a = classPropertyValue.b();
			}
			if (a == "1e6a4420-6f5b-4b7c-b3b5-1f54e58873cb")
			{
				this.Subject.y6()[ddq.ay] = new bt4("deputySearches1");
			}
			else if (a == "deputySearches1")
			{
				this.Subject.y6()[ddq.ay] = new bt4("deputySearches2");
			}
			else if (a == "deputySearches2")
			{
				this.Subject.y6()[ddq.ay] = new bt4("deputySearches3");
			}
			else
			{
				this.Subject.y6()[ddq.ay] = new bt4("1e6a4420-6f5b-4b7c-b3b5-1f54e58873cb");
				serviceOrThrow.aqu().r()["npc_jye_deputy_startSearch"] = false;
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jye_deputy_firstSearchDone", new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()["npc_jye_deputy_firstSearchDone"] = true;
				}
				else
				{
					serviceOrThrow.aqu().r()["npc_jye_deputy_secondSearchDone"] = true;
				}
			}
			serviceOrThrow.aqu().r()["npc_jye_deputy_nextWaypoint"] = A_0 + TimeSpan.FromSeconds(10.0);
		}
		return ej1.b;
	}

	// Token: 0x020003C2 RID: 962
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A21 RID: 6689 RVA: 0x0008C9B0 File Offset: 0x0008ABB0
		internal bool a(TimeSpan A_0, double A_1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jye_deputy_startSearch", new bool?(false)).Value)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("npc_jye_deputy_nextWaypoint", null);
				return primitivePropertyValue == null || primitivePropertyValue.Value <= A_0;
			}
			return false;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0008CA34 File Offset: 0x0008AC34
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000EB3 RID: 3763
		public static readonly a7y.a a = new a7y.a();

		// Token: 0x04000EB4 RID: 3764
		public static Func<TimeSpan, double, bool> b;

		// Token: 0x04000EB5 RID: 3765
		public static Func<bool, float> c;
	}
}
