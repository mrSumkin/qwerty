using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02002148 RID: 8520
[bmq("1.1.1.4_Jy4_FixWasteWaterCaveWalls", "1.1.1.4", "jyt4", true)]
public sealed class eqo : fg
{
	// Token: 0x0600C8D5 RID: 51413 RVA: 0x0046E140 File Offset: 0x0046C340
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("frag_dun_wasteWater", new bool?(false)).Value)
			{
				c5x c5x = new ar7(new Guid("29f2a02a-23b2-45f4-9d9e-ebd5a8bb2617"), A_1.n("jyt4")).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("2a41d483-779d-4b32-af6c-966b140792db"), A_1.n("jyt4")).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("ec7613ed-b028-439a-b977-5574f6d21efe"), A_1.n("jyt4")).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("e4190121-b8ad-49b6-a966-89a42d61031a"), A_1.n("jyt4")).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("52a4dfff-cd39-4d4e-a7a5-b6f7e1b4f26b"), A_1.n("jyt4")).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
				if (c5x2 != null)
				{
					c5x2.w();
					c5x2.an();
				}
				if (c5x3 != null)
				{
					c5x3.w();
					c5x3.an();
				}
				if (c5x4 != null)
				{
					c5x4.w();
					c5x4.an();
				}
				if (c5x5 != null)
				{
					c5x5.w();
					c5x5.an();
				}
				cdo cdo = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(A_1.n("jyt4").Triggers, new Func<ya, bool>(eqo.a.a.a))) as cdo;
				if (cdo != null)
				{
					cdo.b().c("FromWest2");
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}

	// Token: 0x02002149 RID: 8521
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600C8D9 RID: 51417 RVA: 0x0046E340 File Offset: 0x0046C540
		internal bool a(ya A_0)
		{
			return A_0.Name == "9b3c72b6-9e0c-450e-9d3d-4c09c2ef2d13";
		}

		// Token: 0x04004A02 RID: 18946
		public static readonly eqo.a a = new eqo.a();

		// Token: 0x04004A03 RID: 18947
		public static Func<ya, bool> b;
	}
}
