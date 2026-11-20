using System;
using System.Runtime.CompilerServices;

// Token: 0x020002BD RID: 701
[apc("bostonBotFreezer")]
public sealed class aqb : cqw
{
	// Token: 0x06001463 RID: 5219 RVA: 0x00058B2C File Offset: 0x00056D2C
	public aqb()
	{
		fh fh = new fh(new arr[0]);
		fh fh2 = fh;
		arr[] array = new arr[2];
		array[0] = new arr(this.c, new Func<e1k, bool>(aqb.a.a.a));
		array[1] = new arr(this.d.a, null);
		fh2.a(array);
		this.d.a = fh;
	}

	// Token: 0x020002BE RID: 702
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001466 RID: 5222 RVA: 0x00058BC0 File Offset: 0x00056DC0
		internal bool a(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().Dead && amc.aa().SpecialStates.h;
		}

		// Token: 0x04000B2E RID: 2862
		public static readonly aqb.a a = new aqb.a();

		// Token: 0x04000B2F RID: 2863
		public static Func<e1k, bool> b;
	}
}
