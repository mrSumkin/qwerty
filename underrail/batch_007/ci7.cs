using System;
using Microsoft.Xna.Framework.Graphics;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Common.Settings;

// Token: 0x02000726 RID: 1830
internal static class ci7
{
	// Token: 0x06002F70 RID: 12144 RVA: 0x0011F878 File Offset: 0x0011DA78
	public static cne n()
	{
		if (ci7.a == null)
		{
			ci7.a = bpo.GetServiceOrThrow<cne>();
		}
		return ci7.a;
	}

	// Token: 0x06002F71 RID: 12145 RVA: 0x0011F894 File Offset: 0x0011DA94
	public static Texture2D m()
	{
		return ci7.GetSystemAsset<Texture2D>(bo1.ar);
	}

	// Token: 0x06002F72 RID: 12146 RVA: 0x0011F8A0 File Offset: 0x0011DAA0
	public static Texture2D l()
	{
		return ci7.GetSystemAsset<Texture2D>(bo1.af);
	}

	// Token: 0x06002F73 RID: 12147 RVA: 0x0011F8AC File Offset: 0x0011DAAC
	public static Texture2D k()
	{
		return ci7.GetSystemAsset<Texture2D>(bo1.ag);
	}

	// Token: 0x06002F74 RID: 12148 RVA: 0x0011F8B8 File Offset: 0x0011DAB8
	public static Texture2D j()
	{
		return ci7.GetSystemAsset<Texture2D>(bo1.ah);
	}

	// Token: 0x06002F75 RID: 12149 RVA: 0x0011F8C4 File Offset: 0x0011DAC4
	public static Texture2D i()
	{
		return ci7.GetSystemAsset<Texture2D>(bo1.bq);
	}

	// Token: 0x06002F76 RID: 12150 RVA: 0x0011F8D0 File Offset: 0x0011DAD0
	public static Texture2D h()
	{
		return ci7.GetSystemAsset<Texture2D>(bo1.@as);
	}

	// Token: 0x06002F77 RID: 12151 RVA: 0x0011F8DC File Offset: 0x0011DADC
	public static Texture2D g()
	{
		return ci7.GetSystemAsset<Texture2D>(bo1.at);
	}

	// Token: 0x06002F78 RID: 12152 RVA: 0x0011F8E8 File Offset: 0x0011DAE8
	public static SpriteFont f()
	{
		return ci7.GetSystemAsset<SpriteFont>(ci7.e());
	}

	// Token: 0x06002F79 RID: 12153 RVA: 0x0011F8F8 File Offset: 0x0011DAF8
	public static string e()
	{
		switch (bpo.GetServiceOrThrow<cnk>().aq1().b().l())
		{
		case InterfaceElementSize2.Large:
			return egg.au;
		case InterfaceElementSize2.ExtraLarge:
			return egg.ay;
		case InterfaceElementSize2.Huge:
			return egg.a2;
		}
		return egg.ad;
	}

	// Token: 0x06002F7A RID: 12154 RVA: 0x0011F950 File Offset: 0x0011DB50
	public static string d()
	{
		switch (bpo.GetServiceOrThrow<cnk>().aq1().b().l())
		{
		case InterfaceElementSize2.Large:
			return egg.am;
		case InterfaceElementSize2.ExtraLarge:
			return egg.au;
		case InterfaceElementSize2.Huge:
			return egg.ay;
		}
		return egg.ad;
	}

	// Token: 0x06002F7B RID: 12155 RVA: 0x0011F9A8 File Offset: 0x0011DBA8
	public static string c()
	{
		switch (bpo.GetServiceOrThrow<cnk>().aq1().b().l())
		{
		case InterfaceElementSize2.Large:
			return egg.au;
		case InterfaceElementSize2.ExtraLarge:
			return egg.ay;
		case InterfaceElementSize2.Huge:
			return egg.a2;
		}
		return egg.am;
	}

	// Token: 0x06002F7C RID: 12156 RVA: 0x0011FA00 File Offset: 0x0011DC00
	public static SpriteFont b()
	{
		return ci7.GetSystemAsset<SpriteFont>(ci7.d());
	}

	// Token: 0x06002F7D RID: 12157 RVA: 0x0011FA0C File Offset: 0x0011DC0C
	public static SpriteFont a()
	{
		return ci7.GetSystemAsset<SpriteFont>(ci7.c());
	}

	// Token: 0x06002F7E RID: 12158 RVA: 0x0011FA1C File Offset: 0x0011DC1C
	public static T GetSystemAsset<T>(string path) where T : class
	{
		T resource = ci7.n().GetResource<T>(path, null);
		if (resource == null)
		{
			dux.a(LogSeverity.CriticalError, rz.h, new object[]
			{
				path
			});
		}
		return resource;
	}

	// Token: 0x04001A38 RID: 6712
	private static cne a;
}
