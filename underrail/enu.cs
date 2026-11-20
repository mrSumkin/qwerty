using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Xna.Framework;
using Ouroboros.Common;
using Ouroboros.Core.Logging;

// Token: 0x02000003 RID: 3
public sealed class enu : tb
{
	// Token: 0x06000004 RID: 4 RVA: 0x000025B8 File Offset: 0x000007B8
	public override Color atp()
	{
		return new Color(255, 140, 30, 255);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000025D0 File Offset: 0x000007D0
	public override string atq()
	{
		return egg.ai;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000025D8 File Offset: 0x000007D8
	public enu() : base(true)
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000025E4 File Offset: 0x000007E4
	protected override void atr(out OuroborosDisplayMode A_0, out int A_1, out int A_2, out bool A_3)
	{
		ls ls = ls.a();
		egd egd = efw.a(ls.g().a);
		A_0 = ls.g().b;
		A_3 = ls.g().c;
		A_1 = egd.a;
		A_2 = egd.b;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002634 File Offset: 0x00000834
	protected override string ats(int A_0)
	{
		if (A_0 > 1200)
		{
			return egg.bh;
		}
		if (A_0 > 800)
		{
			return egg.a2;
		}
		return egg.am;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002660 File Offset: 0x00000860
	protected override d2a att()
	{
		d2a d2a = new d2a();
		d2a.d("gameconfig.xml");
		d2a.d().a(true);
		d2a.d().a("Underrail");
		d2a.d().a(LogSeverity.None);
		d2a.d().b(LogSeverity.Information);
		d2a.d().a(0);
		d2a.a(new a5g("IPW", typeof(es4), true));
		d2a.a().Add(new a5g("GM", typeof(alx), true));
		d2a.a().Add(new a5g("PM", typeof(dx4), true));
		d2a.a().Add(new a5g("PTFM", typeof(bdb), true));
		d2a.a().Add(new a5g("EM", typeof(cqg), true));
		d2a.a().Add(new a5g("DM", typeof(b77), true));
		d2a.a().Add(new a5g("AM", typeof(dzj), true));
		d2a.a().Add(new a5g("TM", typeof(c6z), true));
		d2a.b().Add(new dbc(new Guid("{96F5B0FF-A7AB-4462-8756-7BD85E08F2A9}"), true));
		d2a.b().Add(new dbc(new Guid("{EA2AE4E1-5CF8-494c-B151-DD0C6BFA2562}"), true));
		d2a.b().Add(new dbc(new Guid("{95B3C2C8-B31C-4cad-8B6B-25E5E909016D}"), true));
		d2a.b().Add(new dbc(new Guid("{BE60E511-6489-44e9-8361-7D25A366F7AA}"), true));
		d2a.b().Add(new dbc(new Guid("{48F960F2-4A39-45d2-AFBE-900AA9750012}"), true));
		d2a.g().Add(new eaa(new Guid("{7F355B27-B05B-4f96-8A96-BCCCA68A795E}"), true));
		return d2a;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002860 File Offset: 0x00000A60
	protected override void atu(object A_0)
	{
		base.atu(null);
		bmg.a = false;
		egg.v = false;
		base.kv("Initializing process manager");
		bpo.RegisterService<bjk>(new b06());
		AppDomain.CurrentDomain.UnhandledException += this.a;
		base.kv("Initializing Steam manager");
		bpo.RegisterService<akt>(new efl());
		if (File.Exists("Galaxy.dll"))
		{
			base.kv("Initializing Galaxy manager");
			bpo.RegisterService<acv>(new axn());
		}
		base.kv("Initializing custom portraits");
		string text = d5x.j();
		if (!Directory.Exists(text))
		{
			string text2 = d5x.i();
			if (Directory.Exists(text2))
			{
				base.kv("Copying default custom portraits");
				cjf.b(text2, text);
			}
		}
		cvr.a();
		EventHandler eventHandler = A_0 as EventHandler;
		if (eventHandler != null)
		{
			eventHandler(this, null);
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002940 File Offset: 0x00000B40
	protected override void OnExiting(object sender, EventArgs args)
	{
		akt service = bpo.GetService<akt>();
		if (service != null)
		{
			service.ast();
		}
		acv service2 = bpo.GetService<acv>();
		if (service2 != null)
		{
			service2.sx();
		}
		base.OnExiting(sender, args);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x0000297C File Offset: 0x00000B7C
	protected override void EndRun()
	{
		base.EndRun();
		if (cxc.a())
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000299C File Offset: 0x00000B9C
	protected override void Update(GameTime gameTime)
	{
		akt service = bpo.GetService<akt>();
		if (service != null)
		{
			service.ass();
		}
		acv service2 = bpo.GetService<acv>();
		if (service2 != null)
		{
			service2.sw();
		}
		bcm bcm = bjn.b();
		if (bcm != null && bcm.aau() is el2)
		{
			if (!enu.c)
			{
				enu.c = true;
				enu.a = enu.b;
			}
			else
			{
				a3o.a();
				if ((enu.a -= gameTime.ElapsedGameTime.TotalMilliseconds) <= 0.0)
				{
					cne service3 = bpo.GetService<cne>();
					if (service3 != null)
					{
						service3.uz(false);
					}
					enu.a = enu.b;
				}
			}
		}
		else
		{
			enu.c = false;
		}
		base.Update(gameTime);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002A68 File Offset: 0x00000C68
	private void a(object A_0, UnhandledExceptionEventArgs A_1)
	{
		try
		{
			string text = d5x.e();
			if (Directory.Exists(text))
			{
				string text2 = Path.Combine(text, string.Format("CrashLog-{0}.txt", DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss")));
				string text3 = string.Format("Версия игры: {0}\r\nОшибка: {1}", dm9.d, A_1.ExceptionObject.ToString());
				File.WriteAllText(text2, text3);
			}
		}
		catch
		{
		}
	}

	// Token: 0x04000003 RID: 3
	private static double a;

	// Token: 0x04000004 RID: 4
	private static readonly double b = TimeSpan.FromMinutes(10.0).TotalMilliseconds;

	// Token: 0x04000005 RID: 5
	private static bool c;
}
