using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x0200046D RID: 1133
public sealed class a4a : adt
{
	// Token: 0x06001D62 RID: 7522 RVA: 0x000A2D50 File Offset: 0x000A0F50
	public a4a(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x000A2D5C File Offset: 0x000A0F5C
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		KeyValuePair<string, Point>? keyValuePair = null;
		if (this.Subject != null)
		{
			HashSet<string> hashSet = this.Subject.y6()["lgBlockedSafePlaces"] as HashSet<string>;
			if (hashSet == null)
			{
				hashSet = new HashSet<string>();
				this.Subject.y6()["lgBlockedSafePlaces"] = hashSet;
			}
			if (this.Subject.a8() != null && this.Subject.a8().Area != null && this.Subject.a8().Area.Zone != null)
			{
				List<csd> list = a4a.a(this.Subject.a8(), this.Subject.a8().Area);
				foreach (csd csd in list)
				{
					if (!hashSet.Contains(csd.Name))
					{
						keyValuePair = new KeyValuePair<string, Point>?(new KeyValuePair<string, Point>(csd.Name, csd.Location.a()));
						break;
					}
				}
				if (keyValuePair == null)
				{
					hashSet.Clear();
					if (list.Count > 0)
					{
						keyValuePair = new KeyValuePair<string, Point>?(new KeyValuePair<string, Point>(list[0].Name, list[0].Location.a()));
					}
				}
			}
		}
		this.Subject.y6()["lgSafePlaceLoc"] = keyValuePair;
		return ej1.b;
	}

	// Token: 0x06001D64 RID: 7524 RVA: 0x000A2EF4 File Offset: 0x000A10F4
	public override float km(bool A_0)
	{
		return 0.5f;
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x000A2EFC File Offset: 0x000A10FC
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return true;
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x000A2F04 File Offset: 0x000A1104
	public static List<csd> a(b0b A_0, aud A_1)
	{
		List<a4a.a> list = new List<a4a.a>();
		foreach (csd csd in A_1.Zone.Waypoints)
		{
			if (csd != null && csd.Area == A_1 && csd.Name != null && csd.Name.StartsWith("lgSafePlace"))
			{
				float a_ = bnx.a(A_0.Location.a(), csd.Location.a());
				list.Add(new a4a.a(a_, csd));
			}
		}
		list.Sort(new Comparison<a4a.a>(a4a.b.a.a));
		return new List<csd>(Enumerable.Select<a4a.a, csd>(list, new Func<a4a.a, csd>(a4a.b.a.a)));
	}

	// Token: 0x0200046E RID: 1134
	private class a
	{
		// Token: 0x06001D67 RID: 7527 RVA: 0x000A3010 File Offset: 0x000A1210
		public a(float A_0, csd A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x04001039 RID: 4153
		public float a;

		// Token: 0x0400103A RID: 4154
		public csd b;
	}

	// Token: 0x0200046F RID: 1135
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x06001D6A RID: 7530 RVA: 0x000A303C File Offset: 0x000A123C
		internal int a(a4a.a A_0, a4a.a A_1)
		{
			return A_0.a.CompareTo(A_1.a);
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x000A3050 File Offset: 0x000A1250
		internal csd a(a4a.a A_0)
		{
			return A_0.b;
		}

		// Token: 0x0400103B RID: 4155
		public static readonly a4a.b a = new a4a.b();

		// Token: 0x0400103C RID: 4156
		public static Comparison<a4a.a> b;

		// Token: 0x0400103D RID: 4157
		public static Func<a4a.a, csd> c;
	}
}
