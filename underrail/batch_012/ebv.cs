using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000469 RID: 1129
public sealed class ebv : adt
{
	// Token: 0x06001D4F RID: 7503 RVA: 0x000A2818 File Offset: 0x000A0A18
	public ebv(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D50 RID: 7504 RVA: 0x000A2824 File Offset: 0x000A0A24
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		HashSet<Guid> hashSet = this.Subject.y6()["lgBlockedMushrooms"] as HashSet<Guid>;
		if (hashSet == null)
		{
			hashSet = new HashSet<Guid>();
			this.Subject.y6()["lgBlockedMushrooms"] = hashSet;
		}
		List<b0b> list = this.a();
		if (list.Count == 0)
		{
			return ej1.c;
		}
		if (hashSet.Count == list.Count)
		{
			hashSet.Clear();
		}
		foreach (b0b b0b in list)
		{
			if (!hashSet.Contains(b0b.qe()))
			{
				this.Subject.y6()["lgTargetMushroom"] = new ar7(b0b);
				break;
			}
		}
		return ej1.b;
	}

	// Token: 0x06001D51 RID: 7505 RVA: 0x000A290C File Offset: 0x000A0B0C
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6()["lgTargetMushroom"] == null;
	}

	// Token: 0x06001D52 RID: 7506 RVA: 0x000A2928 File Offset: 0x000A0B28
	private List<b0b> a()
	{
		d60 addon = this.Subject.a8().Zone.GetAddon<d60>();
		if (addon != null)
		{
			List<b0b> list = addon.ab2(new List<string>
			{
				"lakeMushroom"
			});
			if (list != null)
			{
				List<KeyValuePair<b0b, float>> list2 = new List<KeyValuePair<b0b, float>>();
				Point a_ = this.Subject.a8().Location.a();
				foreach (b0b b0b in list)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.s.b != null)
					{
						list2.Add(new KeyValuePair<b0b, float>(c5x, bnx.a(c5x.Location.a(), a_)));
					}
				}
				list2.Sort(new Comparison<KeyValuePair<b0b, float>>(ebv.a.a.a));
				return new List<b0b>(Enumerable.Select<KeyValuePair<b0b, float>, b0b>(list2, new Func<KeyValuePair<b0b, float>, b0b>(ebv.a.a.a)));
			}
		}
		return new List<b0b>();
	}

	// Token: 0x0200046A RID: 1130
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06001D55 RID: 7509 RVA: 0x000A2A70 File Offset: 0x000A0C70
		internal int a(KeyValuePair<b0b, float> A_0, KeyValuePair<b0b, float> A_1)
		{
			return A_0.Value.CompareTo(A_1.Value);
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x000A2A94 File Offset: 0x000A0C94
		internal b0b a(KeyValuePair<b0b, float> A_0)
		{
			return A_0.Key;
		}

		// Token: 0x04001035 RID: 4149
		public static readonly ebv.a a = new ebv.a();

		// Token: 0x04001036 RID: 4150
		public static Comparison<KeyValuePair<b0b, float>> b;

		// Token: 0x04001037 RID: 4151
		public static Func<KeyValuePair<b0b, float>, b0b> c;
	}
}
