using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x02001866 RID: 6246
[e79(TimelapseWorkflows.ChangeZone)]
public sealed class di4 : b8q
{
	// Token: 0x06008508 RID: 34056 RVA: 0x00374BD0 File Offset: 0x00372DD0
	public di4(c2w A_0) : this(A_0, true, null, 0, null, true, false, false)
	{
	}

	// Token: 0x06008509 RID: 34057 RVA: 0x00374BFC File Offset: 0x00372DFC
	public di4(c2w A_0, bool A_1, bool? A_2 = null, int A_3 = 0, Point? A_4 = null, bool A_5 = true, bool A_6 = false, bool A_7 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_2 != null)
		{
			this.a = A_2.Value;
		}
		else
		{
			this.a = (serviceOrThrow.aq1().d().c() && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("hidePlayer", new bool?(false)).Value);
		}
		base.ErrorHandling = d3s.c;
		base.f().Add(new dtn(serviceOrThrow.aqu().c().b(), (A_0 != null) ? A_0.b() : null, (A_0 != null) ? A_0.c() : null));
		base.f().Add(new ar0());
		base.f().Add(new cqx());
		if (this.a)
		{
			base.f().Add(new d08());
			base.f().Add(new eet());
		}
		if (A_3 > 0)
		{
			base.f().Add(new os(TimeSpan.FromMilliseconds((double)A_3)));
		}
		if (A_1)
		{
			dky dky = new dky();
			if (A_7)
			{
				dky.a(false);
			}
			base.f().Add(dky);
		}
		base.f().Add(new av2());
		base.f().Add(new qt());
		base.f().Add(new zi());
		base.f().Add(new a5o(A_0, A_4));
		if (this.a)
		{
			base.f().Add(new b19("autosave", true, serviceOrThrow.aq1().d().b()));
		}
		base.f().Add(new ezo(true));
		base.f().Add(new dzv());
		if (A_6)
		{
			base.f().Add(new cg());
			if (A_5)
			{
				List<btm> list = base.f();
				c8s c8s = new c8s();
				c8s.a(0.3f);
				list.Add(c8s);
			}
		}
		else
		{
			if (A_5)
			{
				List<btm> list2 = base.f();
				c8s c8s2 = new c8s();
				c8s2.a(0.3f);
				list2.Add(c8s2);
			}
			base.f().Add(new cg());
		}
		if (this.a)
		{
			base.f().Add(new b1d());
		}
		base.f().Add(new by());
		base.f().Add(new ehb());
		base.f().Add(new ba4());
	}

	// Token: 0x0600850A RID: 34058 RVA: 0x00374EA8 File Offset: 0x003730A8
	public override btm ev(Exception A_0, btm A_1)
	{
		try
		{
			string text = d5x.e();
			if (Directory.Exists(text))
			{
				string text2 = Path.Combine(text, string.Format("TransitionError-{0}.txt", DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss")));
				string text3 = string.Format("Версия игры: {0}\r\nОшибка: {1}", dm9.d, A_0.ToString());
				File.WriteAllText(text2, text3);
			}
		}
		catch
		{
		}
		return new hr(this);
	}

	// Token: 0x040032FA RID: 13050
	private new bool a;
}
