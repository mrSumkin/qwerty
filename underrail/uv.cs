using System;
using System.Diagnostics;

// Token: 0x020021EA RID: 8682
[bmq("1.0.0.8_FixLostVaultTradersKey", "1.0.0.8", "lux-b9", false)]
public sealed class uv : fg
{
	// Token: 0x0600CA2D RID: 51757 RVA: 0x00478FA8 File Offset: 0x004771A8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("d86201d0-f8b8-44a2-8335-2f5a8d741c9f"), A_1.n("lux-b9")).ao() as c5x;
			if (c5x != null)
			{
				d2b aspect = c5x.GetAspect<d2b>();
				if (aspect != null && !string.IsNullOrEmpty(aspect.i()))
				{
					aspect.a(null);
					aspect.b("key.luxTrader");
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
}
