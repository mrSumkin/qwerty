using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200040D RID: 1037
[fe("jy_gamblingHouseScrapper")]
public sealed class bj : b5g
{
	// Token: 0x06001B6D RID: 7021 RVA: 0x00095BE8 File Offset: 0x00093DE8
	public bj(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new b64("Roam", new Func<TimeSpan, double, bool>(bj.a.a.a), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(bj.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001B6E RID: 7022 RVA: 0x00095C78 File Offset: 0x00093E78
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string text = null;
			bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay);
			if (classPropertyValue != null)
			{
				text = classPropertyValue.b();
			}
			if (text == null || text == "scrapper2")
			{
				this.Subject.y6()[ddq.ay] = new bt4("scrapper1");
			}
			else
			{
				this.Subject.y6()[ddq.ay] = new bt4("scrapper2");
			}
			serviceOrThrow.aqu().r()["npc_jy8scrapper_nextRotation"] = A_0 + TimeSpan.FromSeconds(75.0);
		}
		return ej1.b;
	}

	// Token: 0x0200040E RID: 1038
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B71 RID: 7025 RVA: 0x00095D5C File Offset: 0x00093F5C
		internal bool a(TimeSpan A_0, double A_1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("npc_jy8scrapper_nextRotation", null);
				return primitivePropertyValue == null || primitivePropertyValue.Value <= A_0;
			}
			return false;
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00095DB8 File Offset: 0x00093FB8
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F3A RID: 3898
		public static readonly bj.a a = new bj.a();

		// Token: 0x04000F3B RID: 3899
		public static Func<TimeSpan, double, bool> b;

		// Token: 0x04000F3C RID: 3900
		public static Func<bool, float> c;
	}
}
