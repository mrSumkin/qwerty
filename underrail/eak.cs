using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x020002AD RID: 685
[apc("caveHopper")]
public sealed class eak : or
{
	// Token: 0x06001404 RID: 5124 RVA: 0x00053BDC File Offset: 0x00051DDC
	public override bool cp()
	{
		return true;
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x00053BE4 File Offset: 0x00051DE4
	public eak()
	{
		this.a = new bud();
		this.b = new fh(new arr[0]);
		this.a.b = new Func<bud, int>(eak.a.a.a);
		fh fh = this.b;
		arr[] array = new arr[2];
		array[0] = new arr(this.a, new Func<e1k, bool>(eak.a.a.a));
		array[1] = new arr(this.c, null);
		fh.a(array);
		this.i.a = this.b;
		this.a.a.Add(this.c);
		this.p.a = this.a;
	}

	// Token: 0x04000ACB RID: 2763
	private new bud a;

	// Token: 0x04000ACC RID: 2764
	private new fh b;

	// Token: 0x020002AF RID: 687
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600142C RID: 5164 RVA: 0x00056964 File Offset: 0x00054B64
		internal int a(bud A_0)
		{
			A_0.b().c().y6()[cy1.g] = "flee";
			ak1 ak = null;
			KeyValuePair<string, Point>? keyValuePair = A_0.b().c().y6()["lgSafePlaceLoc"] as KeyValuePair<string, Point>?;
			if (keyValuePair != null)
			{
				ak = A_0.b().g().a8().Area.a(keyValuePair.Value.Value);
			}
			else
			{
				List<csd> list = a4a.a(A_0.b().g().a8(), A_0.b().g().a8().Area);
				if (list == null || list.Count == 0)
				{
					return 0;
				}
				csd csd = Enumerable.First<csd>(list);
				if (csd.Area != null)
				{
					ak = csd.Area.a(csd.Location.a());
					A_0.b().c().y6()["lgSafePlaceLoc"] = new KeyValuePair<string, Point>(csd.Name, csd.Location.a());
				}
			}
			if (ak != null && A_0.b().g().a8().k.b != null)
			{
				A_0.b().g().a8().k.b.a(ak, double.MaxValue, 1, 0, true);
			}
			return 0;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00056AE8 File Offset: 0x00054CE8
		internal bool a(e1k A_0)
		{
			bzv bzv = new bzv(A_0.c().y6());
			return bzv.c() + bzv.f() > 0;
		}

		// Token: 0x04000AF3 RID: 2803
		public static readonly eak.a a = new eak.a();

		// Token: 0x04000AF4 RID: 2804
		public static Func<bud, int> b;

		// Token: 0x04000AF5 RID: 2805
		public static Func<e1k, bool> c;
	}
}
