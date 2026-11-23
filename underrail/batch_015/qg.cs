using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Core.Logging;

// Token: 0x02000724 RID: 1828
public sealed class qg : li
{
	// Token: 0x06002F69 RID: 12137 RVA: 0x0011F43C File Offset: 0x0011D63C
	public av0 j9()
	{
		return this.a;
	}

	// Token: 0x06002F6A RID: 12138 RVA: 0x0011F444 File Offset: 0x0011D644
	public dbn ka()
	{
		return this.b;
	}

	// Token: 0x06002F6B RID: 12139 RVA: 0x0011F44C File Offset: 0x0011D64C
	public qg()
	{
		this.a();
	}

	// Token: 0x06002F6C RID: 12140 RVA: 0x0011F45C File Offset: 0x0011D65C
	public void b()
	{
	}

	// Token: 0x06002F6D RID: 12141 RVA: 0x0011F460 File Offset: 0x0011D660
	public void kb(c1a A_0)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			mv mv = service.akw() as mv;
			if (mv != null)
			{
				e6d a_ = new e6d(new GameTime(), default(MouseState), default(KeyboardState));
				a44 a_2 = new a44(true, null, null);
				foreach (aud aud in A_0.Areas)
				{
					foreach (b0b b0b in aud.Entities)
					{
						c5x a_3 = (c5x)b0b;
						mv.n().aiy(a_3, mv, a_, a_2);
					}
				}
			}
		}
		stopwatch.Stop();
	}

	// Token: 0x06002F6E RID: 12142 RVA: 0x0011F568 File Offset: 0x0011D768
	private void a()
	{
		try
		{
			this.b = new dbn(Path.Combine(dr3.d().lf(), d5x.ab));
			this.a = new av0
			{
				a = new esj(48, 24),
				b = 53
			};
		}
		catch (Exception a_)
		{
			dux.a(a_, LogSeverity.CriticalError, rz.e, new object[0]);
		}
	}

	// Token: 0x04001A36 RID: 6710
	private av0 a;

	// Token: 0x04001A37 RID: 6711
	private dbn b;
}
