using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020003CF RID: 975
[fe("crawler")]
public class d8 : am2
{
	// Token: 0x06001A4A RID: 6730 RVA: 0x0008DD40 File Offset: 0x0008BF40
	public d8(bm6 A_0) : base(A_0)
	{
		Enumerable.First<c96>(Enumerable.Where<c96>((Enumerable.First<c96>(Enumerable.Where<c96>((Enumerable.First<c96>(Enumerable.Where<c96>(base.g(), new Func<c96, bool>(d8.a.a.a))) as pd).g(), new Func<c96, bool>(d8.a.a.c))) as e8n).g(), new Func<c96, bool>(d8.a.a.b)));
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

	// Token: 0x020003D0 RID: 976
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A4D RID: 6733 RVA: 0x0008DE94 File Offset: 0x0008C094
		internal bool a(c96 A_0)
		{
			return A_0.Name == "CombatNearEnemies";
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0008DEA8 File Offset: 0x0008C0A8
		internal bool c(c96 A_0)
		{
			return A_0.Name == "FocusPrimaryTarget";
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0008DEBC File Offset: 0x0008C0BC
		internal bool b(c96 A_0)
		{
			return A_0.Name == "AutoAttackCurrentTarget";
		}

		// Token: 0x04000EC3 RID: 3779
		public static readonly d8.a a = new d8.a();

		// Token: 0x04000EC4 RID: 3780
		public static Func<c96, bool> b;

		// Token: 0x04000EC5 RID: 3781
		public static Func<c96, bool> c;

		// Token: 0x04000EC6 RID: 3782
		public static Func<c96, bool> d;
	}
}
