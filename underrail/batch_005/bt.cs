using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000B81 RID: 2945
[eiz("CCCPHSJ")]
[Serializable]
public sealed class bt : cze, ISerializable
{
	// Token: 0x0600433B RID: 17211 RVA: 0x001A4B5C File Offset: 0x001A2D5C
	private bt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600433C RID: 17212 RVA: 0x001A4B68 File Offset: 0x001A2D68
	public bt()
	{
	}

	// Token: 0x0600433D RID: 17213 RVA: 0x001A4B74 File Offset: 0x001A2D74
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_cc_ph_securityLevel", new int?(0)).Value < 5)
		{
			HashSet<string> hashSet = d39.a(serviceOrThrow.aqu());
			int num = 0;
			if (hashSet.Contains("securityCameras_installed"))
			{
				num++;
			}
			if (Enumerable.FirstOrDefault<string>(Enumerable.Where<string>(hashSet, new Func<string, bool>(bt.a.a.c))) != null)
			{
				num++;
			}
			if (Enumerable.FirstOrDefault<string>(Enumerable.Where<string>(hashSet, new Func<string, bool>(bt.a.a.d))) != null)
			{
				num++;
			}
			if (Enumerable.FirstOrDefault<string>(Enumerable.Where<string>(hashSet, new Func<string, bool>(bt.a.a.a))) != null)
			{
				num++;
			}
			if (Enumerable.FirstOrDefault<string>(Enumerable.Where<string>(hashSet, new Func<string, bool>(bt.a.a.b))) != null)
			{
				num++;
			}
			serviceOrThrow.aqu().r()["loc_cc_ph_securityLevel"] = num;
		}
	}

	// Token: 0x02000B82 RID: 2946
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004340 RID: 17216 RVA: 0x001A4CE4 File Offset: 0x001A2EE4
		internal bool c(string A_0)
		{
			return A_0.Contains("entrance_turrets");
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x001A4CF4 File Offset: 0x001A2EF4
		internal bool d(string A_0)
		{
			return A_0.Contains("upperFloor_balcony_turrets");
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x001A4D04 File Offset: 0x001A2F04
		internal bool a(string A_0)
		{
			return A_0.Contains("mainFloor_hallway_patrol");
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x001A4D14 File Offset: 0x001A2F14
		internal bool b(string A_0)
		{
			return A_0.Contains("upperFloor_hallway_patrol");
		}

		// Token: 0x04001C3B RID: 7227
		public static readonly bt.a a = new bt.a();

		// Token: 0x04001C3C RID: 7228
		public static Func<string, bool> b;

		// Token: 0x04001C3D RID: 7229
		public static Func<string, bool> c;

		// Token: 0x04001C3E RID: 7230
		public static Func<string, bool> d;

		// Token: 0x04001C3F RID: 7231
		public static Func<string, bool> e;
	}
}
