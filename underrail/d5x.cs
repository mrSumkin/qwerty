using System;
using System.IO;

// Token: 0x0200048D RID: 1165
public static class d5x
{
	// Token: 0x06001DC0 RID: 7616 RVA: 0x000A5694 File Offset: 0x000A3894
	public static string f(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		return Path.Combine(Path.Combine(dr3.d().lf(), d5x.ah), A_0);
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x000A56C0 File Offset: 0x000A38C0
	public static string q()
	{
		return Path.Combine(dr3.d().lf(), d5x.o);
	}

	// Token: 0x06001DC2 RID: 7618 RVA: 0x000A56D8 File Offset: 0x000A38D8
	public static string p()
	{
		return Path.Combine(dr3.d().lf(), d5x.p);
	}

	// Token: 0x06001DC3 RID: 7619 RVA: 0x000A56F0 File Offset: 0x000A38F0
	public static string o()
	{
		return Path.Combine(dr3.d().lf(), d5x.q);
	}

	// Token: 0x06001DC4 RID: 7620 RVA: 0x000A5708 File Offset: 0x000A3908
	public static string n()
	{
		dr3.d();
		return Path.Combine(d5x.e(), d5x.w);
	}

	// Token: 0x06001DC5 RID: 7621 RVA: 0x000A5720 File Offset: 0x000A3920
	public static string m()
	{
		dr3.d();
		return Path.Combine(Path.Combine(d5x.e(), d5x.w), d5x.x);
	}

	// Token: 0x06001DC6 RID: 7622 RVA: 0x000A5744 File Offset: 0x000A3944
	public static string l()
	{
		dr3.d();
		return Path.Combine(Path.Combine(d5x.e(), d5x.w), d5x.y);
	}

	// Token: 0x06001DC7 RID: 7623 RVA: 0x000A5768 File Offset: 0x000A3968
	public static string k()
	{
		dr3.d();
		return Path.Combine(d5x.e(), d5x.u);
	}

	// Token: 0x06001DC8 RID: 7624 RVA: 0x000A5780 File Offset: 0x000A3980
	public static string j()
	{
		dr3.d();
		return Path.Combine(d5x.e(), d5x.t);
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x000A5798 File Offset: 0x000A3998
	public static string i()
	{
		return Path.Combine(dr3.d().lf(), d5x.af);
	}

	// Token: 0x06001DCA RID: 7626 RVA: 0x000A57B0 File Offset: 0x000A39B0
	public static string e(string A_0)
	{
		return d5x.d(string.Format("{0} (previous)", A_0));
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x000A57C4 File Offset: 0x000A39C4
	public static string d(string A_0)
	{
		dr3.d();
		return Path.Combine(Path.Combine(d5x.e(), d5x.u), A_0);
	}

	// Token: 0x06001DCC RID: 7628 RVA: 0x000A57E4 File Offset: 0x000A39E4
	public static string h()
	{
		dr3.d();
		return Path.Combine(d5x.e(), d5x.v);
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x000A57FC File Offset: 0x000A39FC
	public static string c(string A_0)
	{
		dr3.d();
		return Path.Combine(Path.Combine(d5x.e(), d5x.v), A_0) + ".char";
	}

	// Token: 0x06001DCE RID: 7630 RVA: 0x000A5824 File Offset: 0x000A3A24
	public static string g()
	{
		return Path.Combine(dr3.d().lf(), d5x.e);
	}

	// Token: 0x06001DCF RID: 7631 RVA: 0x000A583C File Offset: 0x000A3A3C
	public static string b(string A_0)
	{
		return Path.Combine(Path.Combine(dr3.d().lf(), d5x.ag), A_0);
	}

	// Token: 0x06001DD0 RID: 7632 RVA: 0x000A5858 File Offset: 0x000A3A58
	public static string a(string A_0)
	{
		return Path.Combine(Path.Combine(dr3.d().lf(), d5x.s), A_0);
	}

	// Token: 0x06001DD1 RID: 7633 RVA: 0x000A5874 File Offset: 0x000A3A74
	public static string f()
	{
		dr3.d();
		return Path.Combine(d5x.e(), ei.g);
	}

	// Token: 0x06001DD2 RID: 7634 RVA: 0x000A588C File Offset: 0x000A3A8C
	public static string e()
	{
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "My Games\\Underrail");
	}

	// Token: 0x06001DD3 RID: 7635 RVA: 0x000A58A0 File Offset: 0x000A3AA0
	public static string d()
	{
		return Path.Combine(dr3.d().lf(), d5x.aq);
	}

	// Token: 0x06001DD4 RID: 7636 RVA: 0x000A58B8 File Offset: 0x000A3AB8
	public static string c()
	{
		return Path.Combine(dr3.d().lf(), d5x.ar);
	}

	// Token: 0x06001DD5 RID: 7637 RVA: 0x000A58D0 File Offset: 0x000A3AD0
	public static string b()
	{
		return Path.Combine(dr3.d().lf(), d5x.@as);
	}

	// Token: 0x06001DD6 RID: 7638 RVA: 0x000A58E8 File Offset: 0x000A3AE8
	public static string a()
	{
		return Path.Combine(dr3.d().lf(), d5x.ai);
	}

	// Token: 0x0400124A RID: 4682
	public static readonly string a = "Gui\\Icons";

	// Token: 0x0400124B RID: 4683
	public static readonly string b = "Gui\\Textures";

	// Token: 0x0400124C RID: 4684
	public static readonly string c = "Gui\\Cursors";

	// Token: 0x0400124D RID: 4685
	public static readonly string d = "Gui\\Images";

	// Token: 0x0400124E RID: 4686
	public static readonly string e = "concept\\pv";

	// Token: 0x0400124F RID: 4687
	public static readonly string f = "concept";

	// Token: 0x04001250 RID: 4688
	public static readonly string g = "Locale";

	// Token: 0x04001251 RID: 4689
	public static readonly string h = "Locale\\Meta";

	// Token: 0x04001252 RID: 4690
	public static readonly string i = "Fonts";

	// Token: 0x04001253 RID: 4691
	public static readonly string j = "Icons";

	// Token: 0x04001254 RID: 4692
	public static readonly string k = "Knowledge";

	// Token: 0x04001255 RID: 4693
	public static readonly string l = "Localization";

	// Token: 0x04001256 RID: 4694
	public static readonly string m = "Maps";

	// Token: 0x04001257 RID: 4695
	public static readonly string n = "Maps\\Locale";

	// Token: 0x04001258 RID: 4696
	public static readonly string o = "Maps\\Locale\\Static";

	// Token: 0x04001259 RID: 4697
	public static readonly string p = "Maps\\Events\\Static";

	// Token: 0x0400125A RID: 4698
	public static readonly string q = "Maps\\Transports\\Static";

	// Token: 0x0400125B RID: 4699
	public static readonly string r = "Maps\\World";

	// Token: 0x0400125C RID: 4700
	public static readonly string s = "Scripts\\Workflows";

	// Token: 0x0400125D RID: 4701
	public static readonly string t = "CustomPortraits";

	// Token: 0x0400125E RID: 4702
	public static readonly string u = "Saves";

	// Token: 0x0400125F RID: 4703
	public static readonly string v = "Characters";

	// Token: 0x04001260 RID: 4704
	public static readonly string w = "cgtemp";

	// Token: 0x04001261 RID: 4705
	public static readonly string x = "lmaps";

	// Token: 0x04001262 RID: 4706
	public static readonly string y = "glent";

	// Token: 0x04001263 RID: 4707
	public static readonly string z = "Meta";

	// Token: 0x04001264 RID: 4708
	public static readonly string aa = "Meta\\Materialization";

	// Token: 0x04001265 RID: 4709
	public static readonly string ab = "Meta\\Materialization\\Locale";

	// Token: 0x04001266 RID: 4710
	public static readonly string ac = "Meta\\Materialization\\Models";

	// Token: 0x04001267 RID: 4711
	public static readonly string ad = "Meta\\Playfield";

	// Token: 0x04001268 RID: 4712
	public static readonly string ae = "Meta\\Playfield\\Blueprints";

	// Token: 0x04001269 RID: 4713
	public static readonly string af = "Portraits\\Temp";

	// Token: 0x0400126A RID: 4714
	public static readonly string ag = "Rules\\Characters";

	// Token: 0x0400126B RID: 4715
	public static readonly string ah = "Rules\\Stores";

	// Token: 0x0400126C RID: 4716
	public static readonly string ai = "Rules\\Items";

	// Token: 0x0400126D RID: 4717
	public static readonly string aj = "Rules\\Vehicles\\Definitions";

	// Token: 0x0400126E RID: 4718
	public static readonly string ak = "Rules\\Vehicles\\Assembled";

	// Token: 0x0400126F RID: 4719
	public static readonly string al = "Schemas";

	// Token: 0x04001270 RID: 4720
	public static readonly string am = "Dialogs";

	// Token: 0x04001271 RID: 4721
	public static readonly string an = "Audio";

	// Token: 0x04001272 RID: 4722
	public static readonly string ao = "Audio\\Music";

	// Token: 0x04001273 RID: 4723
	public static readonly string ap = "Language";

	// Token: 0x04001274 RID: 4724
	public static readonly string aq = "Fragments\\frags";

	// Token: 0x04001275 RID: 4725
	public static readonly string ar = "Fragments\\cats";

	// Token: 0x04001276 RID: 4726
	public static readonly string @as = "Fragments\\dun";
}
