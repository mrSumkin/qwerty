using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000A32 RID: 2610
[eiz("XPHWDT2DR")]
[Serializable]
public sealed class az1 : bdw, ISerializable
{
	// Token: 0x06003DFD RID: 15869 RVA: 0x00175554 File Offset: 0x00173754
	private az1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DFE RID: 15870 RVA: 0x0017555C File Offset: 0x0017375C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DFF RID: 15871 RVA: 0x00175560 File Offset: 0x00173760
	public az1()
	{
	}

	// Token: 0x06003E00 RID: 15872 RVA: 0x0017556C File Offset: 0x0017376C
	public void av(c1a A_0, cyt A_1)
	{
		d60 addon = A_0.GetAddon<d60>();
		if (addon != null)
		{
			foreach (b0b b0b in addon.ab4(new string[]
			{
				"underRailcar"
			}))
			{
				((c5x)b0b).ae = new float?((float)1);
			}
			foreach (b0b b0b2 in addon.ab4(new string[]
			{
				"railcarParts"
			}))
			{
				c5x c5x = (c5x)b0b2;
				c5x.w();
				c5x.an();
			}
		}
		a7c a7c = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(A_0.n("xphw_darkTer2").Triggers, new Func<ya, bool>(az1.a.a.a))) as a7c;
		if (a7c != null)
		{
			a7c.o();
		}
		c5x c5x2 = new ar7(new Guid("1170487a-f06b-4ae9-bd40-e3d01db2e0ee"), A_0.n("xphw_darkTer2")).ao() as c5x;
		if (c5x2 != null)
		{
			eks eks = c5x2.GetAspect<bim>() as eks;
			if (eks != null)
			{
				eks.a(false);
				eks.a(g0.e);
			}
		}
		c5x c5x3 = new ar7(new Guid("e22c59c9-5cea-4eee-b1c7-75316729bb9f"), A_0.n("xphw_darkTer2")).ao() as c5x;
		if (c5x3 != null)
		{
			c5x3.b("gunslingerObservable");
		}
	}

	// Token: 0x02000A33 RID: 2611
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003E03 RID: 15875 RVA: 0x00175734 File Offset: 0x00173934
		internal bool a(ya A_0)
		{
			return A_0.Name == "RailcarVisibility";
		}

		// Token: 0x04001BAD RID: 7085
		public static readonly az1.a a = new az1.a();

		// Token: 0x04001BAE RID: 7086
		public static Func<ya, bool> b;
	}
}
