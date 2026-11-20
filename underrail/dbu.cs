using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020003A4 RID: 932
[fe("spaceSnake")]
public class dbu : am2
{
	// Token: 0x06001996 RID: 6550 RVA: 0x00087890 File Offset: 0x00085A90
	public dbu(bm6 A_0) : base(A_0)
	{
		base.g().Insert(0, new b64("Get void essence", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(dbu.a.a.a), null));
		int num = base.g().IndexOf(Enumerable.First<aif>(Enumerable.OfType<aif>(base.g())));
		base.g().RemoveAt(num);
		base.a(num, new c96[]
		{
			new e1y("IdleMovement", new List<c96>
			{
				new e7y("IdleMoveToTile")
				{
					c = 0.75f,
					b = 5,
					c = 3
				},
				new aif("RestActivity")
			})
			{
				c = 0.5f
			}
		});
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x00087980 File Offset: 0x00085B80
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		return !base.h().aa().StatusEffects.a(cyf.a);
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x000879AC File Offset: 0x00085BAC
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		base.h().aa().StatusEffects.a(new cyf(0), false, false, false);
		return ej1.b;
	}

	// Token: 0x020003A5 RID: 933
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600199B RID: 6555 RVA: 0x000879F0 File Offset: 0x00085BF0
		internal float a(bool A_0)
		{
			return float.MaxValue;
		}

		// Token: 0x04000E93 RID: 3731
		public static readonly dbu.a a = new dbu.a();

		// Token: 0x04000E94 RID: 3732
		public static Func<bool, float> b;
	}
}
